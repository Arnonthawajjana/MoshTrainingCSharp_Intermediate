using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise01_1.Model;

namespace Excercise01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsKeyExit(StringBuilder keyInputStringBuilder)
            {
                return keyInputStringBuilder.ToString().ToLower().Equals("exit");
            }
            bool IsNotValidCommand(StringBuilder keyInputStringBuilder)
            {
                //check for Vaalid command
                return !ManageCommand.Contains(keyInputStringBuilder.ToString());
            }

            //Variable//
            var keyInput = new StringBuilder();
            var myTimeWatch = new CustomsTimeWatch();


            //Process//
            Console.WriteLine("Type 'start' or 'stop' use stopwatch or type 'exit' to close");
            while (true)
            {
                keyInput.Append(Console.ReadLine());
                if (IsKeyExit(keyInput)) break;
                else if (keyInput.Length.Equals(0))
                {
                    Console.WriteLine("Please type a command");
                }
                else if (IsNotValidCommand(keyInput))
                {
                    Console.WriteLine("Please type the valid command");
                }
                else
                {
                    if (keyInput.ToString().ToUpper().Equals(TextCommand.START.ToString()))
                    {
                        myTimeWatch.Start();
                    }
                    else if (keyInput.ToString().ToUpper().Equals(TextCommand.STOP.ToString()))
                    {
                        myTimeWatch.Stop();
                    }
                }
                keyInput.Clear();

            }

        }
    }
}
