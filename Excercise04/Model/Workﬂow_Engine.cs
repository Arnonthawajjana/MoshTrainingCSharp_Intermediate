using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise04.Model
{
    class Workﬂow_Engine
    {
        private List<IWorkFlow> _theWorkFlows = new List<IWorkFlow>();

        internal List<IWorkFlow> TheWorkFlows { get => this._theWorkFlows; set => this._theWorkFlows = value; }

        public void Run()
        {
            foreach (var eachWorkFlow in TheWorkFlows)
            {
                eachWorkFlow.Execute();
            }
        }

        public void ShowStatic()
        {
            Console.WriteLine($"Workflow :{TheWorkFlows.Count} Task");
        }
    }
}
