using System;
using System.Threading.Tasks;
using PingboardApiClient.Internal.Http;
using PingboardApiClient.Models.CustomFields.Requests;
using PingboardApiClient.Models.CustomFields.Responses;

namespace PingboardApiClient
{
    /// <summary>
    /// Used to query Pingboard Api custom fields
    /// </summary>
    public class CustomFieldsClient
    {
        private readonly PingboardHttpFacade _httpFacade;

        internal CustomFieldsClient(PingboardHttpFacade httpFacade)
        {
            _httpFacade = httpFacade;
        }

        /// <summary>
        /// Gets all CustomFields with optional query options
        /// </summary>
        public async Task<CustomFields> GetCustomFieldsAsync()
        {
            return await _httpFacade.GetAsync<CustomFields>("api/v2/custom_fields");
        }

        /// <summary>
        /// Given an id will find the CustomField matching it
        /// </summary>
        public async Task<CustomFields> GetCustomFieldAsync(int id)
        {

            return await _httpFacade.GetAsync<CustomFields>($"api/v2/custom_fields/{id}");
        }

        /// <summary>
        /// Given a CustomField object, will create it
        /// Requires company_admin acccess
        /// </summary>
        public async Task<CustomFields> CreateCustomFieldAsync(CreateCustomFieldRequest createCustomFieldRequest)
        {
            return await _httpFacade.PostAsync<CustomFields, CreateCustomFieldRequest>($"api/v2/custom_fields", createCustomFieldRequest);
        }

        /// <summary>
        /// Given a CustomField object, will update it
        /// Requires company_admin acccess
        /// </summary>
        public async Task<CustomFields> UpdateCustomFieldAsync(int id, CreateCustomFieldRequest createCustomFieldRequest)
        {
            return await _httpFacade.UpdateAsync<CustomFields, CreateCustomFieldRequest>($"api/v2/custom_fields/{id}", createCustomFieldRequest);
        }

        /// <summary>
        /// Given an id, will delete the custom field matching it
        /// Requires company_admin access
        /// </summary>
        public async Task DeleteCustomFieldAsync(int id)
        {
            await _httpFacade.DeleteAsync($"api/v2/custom_fields/{id}");
        }
    }
}
