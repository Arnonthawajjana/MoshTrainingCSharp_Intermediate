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
            Console.WriteLine($"{this.GetType().Name} Initailize");
        }

        public override bool OpenConnection()
        {
            Console.WriteLine($"\n{this.GetType().Name} Connected");
            return true;
        }

        public override bool CloseConnection()
        {
            Console.WriteLine($"{this.GetType().Name} Disconnected");
            return true;
        }
    }
}
