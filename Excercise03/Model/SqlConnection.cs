using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03.Model
{
    class SqlConnection : AbstractDbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("SQL Connection Initailize");
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("Connected");
            return true;
        }

        public override bool CloseConnection()
        {
            Console.WriteLine("Disconnected");
            return true;
        }
    }
}
