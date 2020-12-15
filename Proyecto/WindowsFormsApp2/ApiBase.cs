using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace WindowsFormsApp2
{
    public class ApiBase
    {
        private String urlApi = "http://herf17-001-site1.ftempurl.com/api/";
        public IRestResponse execApi(String direc,String json)
        {
            urlApi = String.Concat(urlApi, direc);
            var cliente = new RestClient(urlApi);
            cliente.Timeout = -1;
            var peticion = new RestRequest(Method.POST);
            if (!String.IsNullOrEmpty(json))
            {
                peticion.AddHeader("Content-Type", "application/json");
                peticion.AddParameter("application/json", json, ParameterType.RequestBody);
            }
            
            return cliente.Execute(peticion);
        } 
    }
}
