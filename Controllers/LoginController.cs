using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraUFRGS.Controllers
{
    public class LoginController
    {
        private const string connectionString = "Server=localhost;Port=5432;Database=monitora_ufrgs;User Id=postgres;Password=r3c0v4l3;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);



    }
}
