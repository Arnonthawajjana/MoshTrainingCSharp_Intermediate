using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03.Model
{
    class OracleConnection : AbstractDbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("Oracle Connection Initailize");
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
