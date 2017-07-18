using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise04.Model;
using Excercise04.Model.WorkFlow;

namespace Excercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateJob cjJob = new CreateJob();
            UploadFile uploadFile = new UploadFile();
            Verify verify = new Verify();

            cjJob.StepEmulate.Add("CreateJob:01 Step");
            cjJob.StepEmulate.Add("CreateJob:02 Step");
            cjJob.StepEmulate.Add("CreateJob:Finished");

            uploadFile.StepEmulate.Add("uploadFile:01 Step");
            uploadFile.StepEmulate.Add("uploadFile:02 Step");
            uploadFile.StepEmulate.Add("uploadFile:Finished");

            verify.StepEmulate.Add("verify:01 Step");
            verify.StepEmulate.Add("verify:02 Step");
            verify.StepEmulate.Add("verify:Finished");

            Workﬂow_Engine wfEngine = new Workﬂow_Engine();

            wfEngine.TheWorkFlows.Add(cjJob);
            wfEngine.TheWorkFlows.Add(uploadFile);
            wfEngine.TheWorkFlows.Add(verify);

            wfEngine.Run();
            Console.WriteLine();

        }
    }
}
