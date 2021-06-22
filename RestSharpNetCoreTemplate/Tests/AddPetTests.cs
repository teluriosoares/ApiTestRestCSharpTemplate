using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests;

namespace RestSharpNetCoreTemplate.Tests
{
    [TestFixture]
    class AddPetTests : TestBase
    {
        PostAddPetRequest postAddPetRequest;

        [Test]
        public void ShouldAddPet()
        {
            string id = "9846545";
            string name = "Testpet";
            string status = "sold";

            postAddPetRequest = new PostAddPetRequest();
            postAddPetRequest.SetJsonBody(id, name, status);

            IRestResponse<dynamic> response = postAddPetRequest.ExecuteRequest();

            //Assert.AreEqual(expectedStatusCode, response.StatusCode.ToString());

            Assert.Multiple(() =>
            {
                Assert.AreEqual(name, response.Data["name"].ToString());
                Assert.AreEqual(status, response.Data["status"].ToString());
            });

        }

    }
}
