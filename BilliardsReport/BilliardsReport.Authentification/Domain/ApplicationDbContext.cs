using BilliardsReport.Authentification.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BilliardsReport.Authentification.Domain
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base(Constants.Authentification.ConnectionStringName, throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
