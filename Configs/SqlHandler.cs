using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace FinalWork.Configs
{
    public class SqlHandler
    {
        // Server=your_server;Database=your_database;User=your_user;Password=your_password;
        private static string sql_connection_format_str = "Server={0};Database={1};User={2};Password={3};";

        public IDbConnection conn;
        public string sql_connection_str;
        private string sql_server, sql_database, sql_user, sql_password;

        public static SqlHandler Instance { get; private set; } = new SqlHandler();

        private SqlHandler() {
            init(Config.Instance.sql_server, Config.Instance.sql_database, Config.Instance.sql_user, Config.Instance.sql_password);
        }

        public SqlHandler(string sql_server, string sql_database, string sql_user, string sql_password)
        {
            init(sql_server, sql_database, sql_user, sql_password);
        }

        ~SqlHandler() {
            conn.Close();
        }

        public static SqlHandler GetInstance() { return Instance; }
        private void init(string sql_server, string sql_database, string sql_user, string sql_password)
        {
            this.sql_server = sql_server;
            this.sql_database = sql_database;
            this.sql_user = sql_user;
            this.sql_password = sql_password;

            sql_connection_str = string.Format(sql_connection_format_str, sql_server, sql_database, sql_user, sql_password);

            conn = new MySqlConnection(sql_connection_str);

            conn.Open();
        }
    }
}
