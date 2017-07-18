using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise04.Model
{
    interface IWorkFlow
    {
        int CountStep();

        void Execute();
    }
}
