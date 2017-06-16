using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03.Model
{
    abstract class AbstractDbConnection : IDbConnection
    {
        private String _ConnectionString;

        private TimeSpan _TimeOut;

        public string ConnectionString { get => _ConnectionString; }
        public TimeSpan TimeOut { get => _TimeOut; set => _TimeOut = value; }

        protected AbstractDbConnection(String connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new NullReferenceException("ConnectionString is null");
            }
            _ConnectionString = connectionString;
        }
        abstract public bool OpenConnection();

        abstract public bool CloseConnection();

    }
}
