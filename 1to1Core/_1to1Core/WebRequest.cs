using RestSharp;

namespace _1to1Core
{
    class WebRequest
    {
        RequestObject _requestObject;

       /// <summary>
       /// VitalTrax domain
       /// </summary>
       public string  _endPoint   = "";

       /// <summary>
       /// Client-specific URI to hit
       /// </summary>
       public string _requestUrl  = "";

        /// <summary>
        /// Pull data from VitalTrax. Need to create a local _requestObject based on the data pulled from VitalTrax
        /// Example of how to use this: https://stackoverflow.com/questions/10226089/restsharp-simple-complete-example
        /// </summary>
        public void makeWebRequest(string endPoint, string requestUrl)
        {
            var client  = new RestClient(endPoint);
            var request = new RestRequest(requestUrl, Method.GET);

            // Automatically deserialize result
            IRestResponse<RequestObject> response = client.Execute<RequestObject>(request);
            _requestObject                        = response.Data;
        }

    }
}
