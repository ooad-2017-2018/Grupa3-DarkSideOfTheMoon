using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web.Azure
{
    public class ConnectionStringAzure
    {
        public string konekcija = "Server = tcp:darkeri.database.windows.net,1433;Initial Catalog = darkweb; Persist Security Info=False;User ID = { your_username }; Password={your_password}; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
}
}
