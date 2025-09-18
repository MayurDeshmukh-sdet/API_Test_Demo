using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ApiTests;
//using API_Test;
using ApiTests;


namespace ApiTests
{
    [TestClass]
    public class RegressionTests
    {
        [TestMethod]
        public void VerifyUsers()
        {
            var demo = new Demo();
            var responce = demo.GetUsers();
            Assert.AreEqual(2,responce.Id);
            Assert.AreEqual("Cloudy White", responce.Data[0].Color);
        }

        [TestMethod]
        public void CreateNewUser()
        {
            string payload= @"{
                   ""name"": ""Apple MacBook Pro 16"",
                   ""data"": {
                    ""year"": 2019,
                     ""price"": 1849.99,
                         ""CPU model"": ""Intel Core i9"",
                            ""Hard disk size"": ""1 TB""
                                }
                                }";

            var user = new APIHelper <CreateUserDataTransfer>();
            var url = user.SetUrl("/objects");
            var request = user.CreatePostRequest(payload);
            var response = request.GetResponse(url, request);

            CreateUserDataTransfer content = user.GetContent<CreateUserDataTransfer>(response);

            Assert.AreEqual("Apple MacBook Pro 16", content.Name);
            Assert.AreEqual("Intel Core i9", content.CPUmodel);

        }

        [TestMethod]
        public void DeleteUSer()
        {
            
            var deleteHelper = new APIHelper<CreateUserDataTransfer>();
            var deleteUrl = deleteHelper.SetUrl($"/objects/{createdUser.Id}");
            var deleteRequest = deleteHelper.CreateDeleteRequest();
            var deleteResponse = deleteHelper.GetResponse(deleteUrl, deleteRequest);

            // Step 3: Verify status code
            Assert.AreEqual(System.Net.HttpStatusCode.NoContent, deleteResponse.StatusCode);

        }
    }
}
