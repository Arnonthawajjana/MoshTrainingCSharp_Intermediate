using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01_2.Model
{
    public enum TextCommand
    {
        //GETPOST,
        //POST,
        VOTEUP,
        VOTEDOWN,
        EXIT
    }

    public static class ManageCommand
    {
        private static List<String> _listOfTextCommand
            = Enum.GetNames(typeof(TextCommand)).ToList();

        public static Boolean Contains(String compare)
        {
            return _listOfTextCommand.Contains(compare.ToUpper());
        }
    }

}
