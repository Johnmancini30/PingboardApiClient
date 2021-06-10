using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace PingboardApiClient.Internal.Queries
{
    internal abstract class QueryBuilder<T>
    {
        protected class Query
        {
            private readonly NameValueCollection _nameValues = new NameValueCollection();

            public void Add(string name, string value)
                => _nameValues.Add(name, value);

            public void Add(string name, bool value)
                => Add(name, value.ToString().ToLower());

            public void Add(string name, int value)
                => Add(name, value.ToString().ToLower());

            public void Add(string name, IList<string> values)
            {
                if (!values.Any())
                    return;

                Add(name, string.Join(",", values));
            }

            public void Add(string name, IList<int> values)
            {
                foreach (int val in values)
                    Add($"{name}[]", val.ToString());
            }

            public string ToQueryString()
            {
                var array = _nameValues.AllKeys.SelectMany(
                        key => _nameValues.GetValues(key)
                            ?.Select(value => $"{UrlEncode(key)}={UrlEncode(value)}")
                    )
                    .ToArray();
                return array.Any() ? "?" + string.Join("&", array) : string.Empty;
            }

            private static string UrlEncode(string value) =>
                value.Contains("%") ? value : System.Uri.EscapeDataString(value);
        }

        public string Build(string baseUrl, T options)
        {
            var query = new Query();
            BuildCore(query, options);
            return baseUrl + query.ToQueryString();
        }

        protected abstract void BuildCore(Query query, T options);
    }
}
