using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace API_Test
{
    public class APIHelper <T>
    {
        public RestClient restClient;
        public RestResponse restResponse;
        public String BaseUrl = "https://restful-api.dev/";

        public RestClient SetUrl(String endpoint)
        {
            var url = Path.Combine(BaseUrl, endpoint);
            var restClient = new RestClient(url);
            return restClient;

        }

        public RestRequest CreatePostRequest(String payload)
        {
            var restRequest = new RestRequest(Method.Post); //  (Method.Post);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("Content-Type", payload, ParameterType.RequestBody); // "application/json");
            return restRequest;
        }
        public RestResponse GetResponse(RestClient client, RestRequest request)
        { 
        
            return client.Execute(request);

        }

        public DataTrans GetContent <DataTrans>(RestResponse response)
        {
            var content = response.Content;
            DataTrans dtobj = JsonConvert.DeserializeObject<DataTrans>(content);
            return dtobj;


        }


    }
}
