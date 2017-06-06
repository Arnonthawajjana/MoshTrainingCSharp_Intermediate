using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03.Model
{
    abstract class DBConnection
    {
        private String _ConnectionString;

        public string ConnectionString { get => _ConnectionString;}

        protected DBConnection(String connectionString)
        {
        }

        abstract public bool openConnection();

        abstract public bool closeConnection();
    }
}
