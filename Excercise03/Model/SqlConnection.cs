using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03.Model
{
    class SqlConnection : DBConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
    }
}
