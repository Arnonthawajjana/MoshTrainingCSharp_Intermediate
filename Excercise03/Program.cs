using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise03.Model;

namespace Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection theSqlConnection = new SqlConnection("127.0.0.1:4730");
            OracleConnection theOracleConnection = new OracleConnection("127.0.0.1:4550");
            DBCommand theCommand = new DBCommand(theSqlConnection,"SELECT * FROM myTable");
            theCommand.Excute();

            theCommand.DBConnection = theOracleConnection;

            theCommand.Excute();

            Console.ReadLine();

        }
    }
}
