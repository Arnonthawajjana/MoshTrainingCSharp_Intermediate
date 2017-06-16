using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03.Model
{
    interface IDbConnection
    {

        bool OpenConnection();

        bool CloseConnection();
    }
}
