﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BilliardsReport.WcfWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ApiService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ApiService.svc or ApiService.svc.cs at the Solution Explorer and start debugging.
    public class ApiService : IApiService
    {
        [WebGet(UriTemplate = "/Message", ResponseFormat = WebMessageFormat.Json)]
        public string Message()
        {
            return "Hello WOrld!!";
        }
    }
}