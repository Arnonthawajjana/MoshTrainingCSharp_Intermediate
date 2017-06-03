using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise02.Model;

namespace Excercise02
{
    class Program
    {

        static void Main(string[] args)
        {
            NormalStack stack = new NormalStack();

            stack.Push(1);
            stack.Push('P');
            stack.Push("Item lol");

            Console.WriteLine($"Stack size :{stack.Count()}");
            
            var item1 = stack.Pop();
            var item2 = stack.Pop();
            var item3 = stack.Pop();

            Console.WriteLine($"Stack size :{stack.Count()}");

            Console.WriteLine($"{item1.GetType()} : {item1}");
            Console.WriteLine($"{item2.GetType()} : {item2}");
            Console.WriteLine($"{item3.GetType()} : {item3}");
            Console.WriteLine("Its worked");

        }
    }
}
