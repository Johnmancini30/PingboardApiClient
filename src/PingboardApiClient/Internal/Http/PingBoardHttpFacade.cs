using System;
using System.Net.Http;
using System.Threading.Tasks;
using Polly;
using Polly.Extensions.Http;
using Polly.Retry;
using Newtonsoft.Json;
using PingboardApiClient.Models;

namespace PingboardApiClient.Internal.Http
{
    internal class PingboardHttpFacade
    {
        private static HttpClient DefaultClient = new HttpClient(new SocketsHttpHandler {PooledConnectionLifetime = TimeSpan.FromMinutes(10), PooledConnectionIdleTimeout = TimeSpan.FromMinutes(5), MaxConnectionsPerServer = 10});
        private readonly Uri _baseUri;
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly HttpClient _client;
        private DateTime ExpirationTime;

        private AsyncRetryPolicy<HttpResponseMessage> PingboardPolicy = HttpPolicyExtensions
            .HandleTransientHttpError()
            .WaitAndRetryAsync(new[] {TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(4), TimeSpan.FromSeconds(8)});

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseUrl">Host address of Pingboard instance</param>
        /// <param name="clientId">Client Id.</param>
        /// <param name="clientSecret">Client Secret.</param>
        /// <param name="client">Optional HttpClient</param>
        internal PingboardHttpFacade(string baseUrl, string clientId, string clientSecret, HttpClient? client = null)
        {
            _baseUri = new Uri(baseUrl);
            _clientId = clientId;
            _clientSecret = clientSecret;
            _client = client ?? DefaultClient;
            ExpirationTime = DateTime.Now;
        }

        private async Task EnsureToken()
        {
            if (DateTime.Now < ExpirationTime)
            {
                return;
            }

            using (var content = new StringContent($"client_id={_clientId}&client_secret={_clientSecret}", System.Text.Encoding.Default, "application/x-www-form-urlencoded"))
            {
                Uri.TryCreate(_baseUri, "oauth/token?grant_type=client_credentials", out var uri);
                using (var response = await _client.PostAsync(uri, content))
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var authResponse = JsonConvert.DeserializeObject<Authorization>(responseData);
                    _client.DefaultRequestHeaders.TryAddWithoutValidation("authorization", $"Bearer {authResponse.AccessToken}");
                    ExpirationTime = DateTime.Now.AddSeconds((float)authResponse.ExpiresIn * .9);
                }
            }
        }

        internal async Task<T> GetAsync<T>(string relativeUri)
        {
            if (!Uri.TryCreate(_baseUri, relativeUri, out var uri))
            {
                throw new UriFormatException($"Unable to create uri with {_baseUri.ToString()} {relativeUri}");
            }

            await EnsureToken();
            var response = await PingboardPolicy.ExecuteAsync(async () => await _client.GetAsync(uri));
            EnsureSuccess(response);
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        internal async Task<T> PostAsync<T, U>(string relativeUri, U body)
        {
            if (!Uri.TryCreate(_baseUri, relativeUri, out var uri))
            {
                throw new UriFormatException($"Unable to create uri with {_baseUri.ToString()} {relativeUri}");
            }

            await EnsureToken();
            var json = JsonConvert.SerializeObject(body);
            var data = new StringContent(json, System.Text.Encoding.Default, "application/json");
            var response = await PingboardPolicy.ExecuteAsync(async () => await _client.PostAsync(uri, data));
            EnsureSuccess(response);
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        internal async Task<T> UpdateAsync<T, U>(string relativeUri, U body)
        {
            if (!Uri.TryCreate(_baseUri, relativeUri, out var uri))
            {
                throw new UriFormatException($"Unable to create uri with {_baseUri.ToString()} {relativeUri}");
            }

            await EnsureToken();
            var json = JsonConvert.SerializeObject(body);
            var data = new StringContent(json, System.Text.Encoding.Default, "application/json");
            var request = new HttpRequestMessage {Method = new HttpMethod("PATCH"), RequestUri = uri, Content = data};
            var response = await PingboardPolicy.ExecuteAsync(async () => await _client.SendAsync(request));
            EnsureSuccess(response);
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        internal async Task DeleteAsync(string relativeUri)
        {
            if (!Uri.TryCreate(_baseUri, relativeUri, out var uri))
            {
                throw new UriFormatException($"Unable to create uri with {_baseUri.ToString()} {relativeUri}");
            }

            await EnsureToken();
            var response = await PingboardPolicy.ExecuteAsync(async () => await _client.DeleteAsync(uri));
            EnsureSuccess(response);
        }

        private static void EnsureSuccess(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException(response.StatusCode.ToString());
            }
        }
    }
}
