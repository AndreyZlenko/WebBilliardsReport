﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BilliardsReport.WcfWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IApiService" in both code and config file together.
    [ServiceContract]
    public interface IApiService
    {
        [OperationContract]
        string Message();

        [OperationContract]
        int Factorial(int number);
    }
}
