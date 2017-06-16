using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03.Model
{
    class DBCommand
    {
        private AbstractDbConnection _dbconnection;

        DBCommand(AbstractDbConnection dbconnection)
        {
            if (String.IsNullOrEmpty(dbconnection.ConnectionString))
            {
                throw new NullReferenceException("dbConnection is invalid");
            }
            this._dbconnection = dbconnection;
        }
    }
}
