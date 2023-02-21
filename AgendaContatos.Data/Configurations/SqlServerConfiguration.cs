using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos.Data.Configurations
{
    public class SqlServerConfiguration
    {
        public static string ConnectionString
            => "Data Source=NETO\\SQLEXPRESS;Initial Catalog=BDAgendaContatos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
