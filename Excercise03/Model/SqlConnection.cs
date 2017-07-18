using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03.Model
{
    class SqlConnection : AbstractDbConnection
    {
        private TimeSpan _simTimeSpan;

        public SqlConnection(string connectionString) : base(connectionString)
        {
            _simTimeSpan = new TimeSpan();
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
