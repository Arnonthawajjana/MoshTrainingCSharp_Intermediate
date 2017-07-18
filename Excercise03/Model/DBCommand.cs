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

        private String _instruction;

        public DBCommand(AbstractDbConnection dbconnection)
        {
            if (String.IsNullOrEmpty(dbconnection.ConnectionString))
            {
                throw new NullReferenceException("dbConnection is invalid");
            }
            this._dbconnection = dbconnection;
        }
        public DBCommand(AbstractDbConnection dbconnection,String Instruction) :this(dbconnection)
        {
            this.Instruction = Instruction;
        }

        public string Instruction { get => _instruction; set => _instruction = value; }

        public AbstractDbConnection DBConnection { get => _dbconnection; set => _dbconnection = value; }

        public bool Excute()
        {
            if (!String.IsNullOrEmpty(_instruction))
            {
                this._dbconnection.OpenConnection();
                Console.WriteLine($"Command Excute: {Instruction}");
                this._dbconnection.CloseConnection();
                return true;

            }
            return false;
        }
    }
}
