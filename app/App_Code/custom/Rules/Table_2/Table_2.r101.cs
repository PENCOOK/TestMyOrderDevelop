using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using MyCompany.Data;
using MyCompany.Models;
using RestSharp;
using System.Configuration;
using Newtonsoft.Json;

namespace MyCompany.Rules
{
    public partial class Table_2BusinessRules : MyCompany.Rules.SharedBusinessRules
    {

        /// <summary>This method will execute in any view for an action
        /// with a command name that matches "Calculate" and argument that matches "fkcourier".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(Table_2Model instance)
        {
            if (instance.fkcourier != null && instance.trackingNo != null)
            {
                Table_2 obj = new Table_2();
                obj.trackingNo = instance.trackingNo;
                obj.fkcourierTitle = instance.fkcourierTitle;
                var res = Fresh(obj);
                instance.status = res.Data.Status;
                instance.currentStatus = res.Data.CurrentStatus;
            }
        }

        TrackRes.Welcome Fresh(Table_2 obj)
        {
            string trackapikey = ConfigurationManager.AppSettings["trackapikey"].ToString();
            string trackKeySecret = ConfigurationManager.AppSettings["trackKeySecret"].ToString();

            var client = new RestClient("https://fast.etrackings.com/api/v3/tracks/find");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Etrackings-Api-Key", trackapikey);
            request.AddHeader("Etrackings-Key-Secret", trackKeySecret);
            request.AddHeader("Accept-Language", "TH");
            request.AddHeader("Content-Type", "application/json");

            TrackReq reqObj = new TrackReq();
            reqObj.trackingNo = obj.trackingNo;
            reqObj.courier = obj.fkcourierTitle;

            string body = JsonConvert.SerializeObject(reqObj);

            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            var rawData = JsonConvert.DeserializeObject<TrackRes.Welcome>(response.Content);

            return rawData;
        }
    }
}
