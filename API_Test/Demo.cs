using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Test
{
    public class Demo
    {
        public ListOfUsersDataTransfer GetUsers()
        {
            var RestClient = new RestClient("https://restful-api.dev/");
            var RestRequest = new RestRequest("https://api.restful-api.dev/objects" , Method.Get);
            RestRequest.AddHeader("Accept", "application/json");  //("Content-Type", "application/json");
            RestRequest.RequestFormat = DataFormat.Json;
            
            RestResponse response = RestClient.Execute(RestRequest);
            var content = response.Content;
            Console.WriteLine(content);

            var users = JsonConvert.DeserializeObject<ListOfUsersDataTransfer>(content);
            return users;

       
        }

  //      public CreateUserDataTransfer CreateUser()
   //     {
   ///         var RestClient = new RestClient("https://restful-api.dev/");
   ///         var RestRequest = new RestRequest("https://api.restful-api.dev/objects", Method.Post);
 ///           RestRequest.AddHeader("Accept", "application/json");  //("Content-Type", "application/json");
  ///          RestRequest.AddParameter("application/json",)
   ///         RestRequest.RequestFormat = DataFormat.Json;
///
  ///          RestResponse response = RestClient.Execute(RestRequest);
 //           var content = response.Content;
   ///         Console.WriteLine(content);

  ///          var users = JsonConvert.DeserializeObject<ListOfUsersDataTransfer>(content);
   //         return users;


   //     }

    }

   // internal interface IRestResponse
  //  {
   // }
}
