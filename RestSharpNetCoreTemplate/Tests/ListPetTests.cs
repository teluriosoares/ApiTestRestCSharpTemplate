using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Requests;

namespace RestSharpNetCoreTemplate.Tests
{
    
    [TestFixture]
    public class GetPetTests : TestBase
    {

        //ListUsersRequest listUsersPetRequest;
        GetPetRequest getPetRequest;

        [Test]
        public void ShouldSearchPet()
        {
            string expectedStatusCode = "OK";

            //listUsersPetRequest = new ListUsersRequest();
            //IRestResponse<dynamic> response = listUsersPetRequest.ExecuteRequest();

            getPetRequest = new GetPetRequest();
            IRestResponse<dynamic> response = getPetRequest.ExecuteRequest();

            Assert.AreEqual(expectedStatusCode, response.StatusCode.ToString());
        }

    }
}
