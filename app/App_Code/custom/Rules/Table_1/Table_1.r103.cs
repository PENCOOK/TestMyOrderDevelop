using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using MyCompany.Data;
using MyCompany.Models;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Configuration;

namespace MyCompany.Rules
{
    public partial class Table_1BusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        /// <summary>This method will execute in any view for an action
        /// with a command name that matches "Calculate".
        /// </summary>
        [Rule("r103")]
        public void r103Implementation(Table_1Model instance)
        {
            BuildHashLink(instance);
        }
        async Task BuildHashLink(Table_1Model instance)
        {
            string apikey = ConfigurationManager.AppSettings["apikey"].ToString();
            string urlApi = "https://api.apilayer.com/short_url/hash";

            var client = new RestClient(urlApi);
            var request = new RestRequest(urlApi, Method.POST);
            request.AddHeader("apikey", apikey);
            request.AddHeader("Content-Type", "text/plain");
            var body = instance.LongUrl;
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            var response = client.Execute(request);
            var rawData = JsonConvert.DeserializeObject<ResValue>(response.Content); // successfull
            instance.ShortUrl = rawData.short_url;
            instance.Hash = rawData.hash;
        }
    }
}
