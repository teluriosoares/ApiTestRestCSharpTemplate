using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;
using RestSharpNetCoreTemplate.Helpers;
using System.IO;


namespace RestSharpNetCoreTemplate.Requests
{
    public class PostAddPetRequest : RequestBase
    {

        public PostAddPetRequest()
        {
        requestService = "v2/pet";
        method = Method.POST;
        }



        public void SetJsonBody(string id, string name, string status)
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/AddPet.json", Encoding.UTF8);
            jsonBody = jsonBody.Replace("$id", id);
            jsonBody = jsonBody.Replace("$name", name);
            jsonBody = jsonBody.Replace("$status", status);
        }

    }
}
