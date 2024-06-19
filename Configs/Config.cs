using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace FinalWork.Configs
{
    public class Config
    {
        public string sql_server, sql_database, sql_user, sql_password;

        public static Config Instance = new Config();

        public Config() {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("application.conf", optional: true, reloadOnChange: true);

            IConfiguration conf = builder.Build();

            this.sql_server      = conf["server"     ]??throw new ArgumentNullException("server"   );
            this.sql_database    = conf["database"   ]??throw new ArgumentNullException("database" );
            this.sql_user        = conf["user"       ]??throw new ArgumentNullException("user"     );
            this.sql_password    = conf["password"   ]??throw new ArgumentNullException("password" );
        }
    }
}
