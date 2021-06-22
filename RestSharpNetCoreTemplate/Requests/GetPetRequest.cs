using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharpNetCoreTemplate.Bases;

namespace RestSharpNetCoreTemplate.Requests
{
    public class GetPetRequest : RequestBase
    {
        public GetPetRequest()
        {
        }

        public GetPetRequest(string idPet)
        {
            requestService = "v2/pet/" + idPet;
            method = Method.GET;
        }
    }
}
