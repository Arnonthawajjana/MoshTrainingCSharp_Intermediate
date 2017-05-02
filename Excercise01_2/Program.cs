using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise01_2.Model;

namespace Excercise01_2
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
            var exampleTopic = new Topic(0,"Example Topic Stackoverflow post Simulate");
            var postInExampleTopic = new Post(0, "Arnonthawajjana", "Wow!! That is nice ");
            exampleTopic.AddPost(postInExampleTopic);

            //Process//
            Console.WriteLine("Type 'voteup' or 'votedown' to gain or reduce vote type or 'exit' to close \n");
            Console.WriteLine($"Topic: {exampleTopic.TopicName}");
            Console.WriteLine("Post:");
            Console.WriteLine($"username :{postInExampleTopic.Username} ,content :{postInExampleTopic.Content}");
            Console.WriteLine($"vote :{postInExampleTopic.Vote}");
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
                    if (keyInput.ToString().ToUpper().Equals(TextCommand.VOTEUP.ToString()))
                    {
                        postInExampleTopic.VoteUp();
                    }
                    else if (keyInput.ToString().ToUpper().Equals(TextCommand.VOTEDOWN.ToString()))
                    {
                        postInExampleTopic.VoteDown();
                    }
                    Console.WriteLine($"current vote :{postInExampleTopic.Vote}");

                }
                keyInput.Clear();

            }
        }
    }
}
