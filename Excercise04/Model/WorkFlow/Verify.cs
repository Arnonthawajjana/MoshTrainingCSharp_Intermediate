using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Excercise04.Model.WorkFlow
{
    class Verify : IWorkFlow
    {
        private List<String> _stepEmulate = new List<string>();

        public List<string> StepEmulate { get => this._stepEmulate; set => this._stepEmulate = value; }

        public int CountStep()
        {
            Console.WriteLine($"{this.GetType().ToString()} :{StepEmulate.Count} Tasks");
            return StepEmulate.Count;
        }

        public void ShowWorkFlowStep()
        {
            if (StepEmulate.Count == 0)
            {
                Console.WriteLine("No Task");
            }
            else
            {
                _stepEmulate.ForEach(w=>Console.WriteLine(w));
            }
        }

        public void Execute()
        {
            if (StepEmulate.Count == 0)
            {
                Console.WriteLine("No Task");
            }
            else
            {
                Console.WriteLine($"{this.GetType().ToString()} :{StepEmulate.Count} Tasks done");
            }

        }
    }
}
