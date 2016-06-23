using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHGWordAddin
{
    public class WHGApi
    {
        const string BaseUrl = "http://dir-inc.org:8080";

        readonly string _accountId;
        readonly string _secretKey;

        public WHGApi(string accountId, string secretKey)
        {
            this._accountId = accountId;
            this._secretKey = secretKey;
        }

        public WHGApi()
        {
            // TODO: Complete member initialization
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);
            client.AddDefaultHeader("ContentType", "application/json");
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response. Check inner details for more info.";
                var whgException = new ApplicationException(message, response.ErrorException);
                throw whgException;
            }
           
            return response.Data;
        }

        public Glossary GetGlossary()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "webservice/GetGlossary";
            request.RootElement = "json_cats";
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.RequestFormat = DataFormat.Json;

            var r = Execute<Glossary>(request);
 
            return r;
        }
    }
}
