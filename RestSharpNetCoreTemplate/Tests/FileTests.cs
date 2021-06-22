using NUnit.Framework;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using RestSharpNetCoreTemplate.Requests.PetStore;

namespace RestSharpNetCoreTemplate.Tests
{    
    [TestFixture]
    public class FileTests : TestBase
    {

        FileRequest fileRequest;

        [Test]
        public void ShouldDownloadTheFile()
        {
            string statusCodeEsperado = "OK";

            fileRequest = new FileRequest();

            IRestResponse<dynamic> response = fileRequest.ExecuteFileRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }

        
        
    }
}
