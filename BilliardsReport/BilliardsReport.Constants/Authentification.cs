using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsReport.Constants
{
    public static class Authentification
    {
        public const string LoginPath = "/Account/Login";

        public const string PublicClientId = "web";
        public const string TokenEndpointPath = "/Token";
        public const string AuthorizeEndpointPath = "/Account/Authorize";

        public const string ConnectionStringName = "identity";
    }
}
