using System.Collections;
using System.Collections.Generic;

namespace PropertyDemo
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workflow)
        {
            foreach (var task in workflow.GetTasks())
            {
                try
                {
                    task.Execute();
                }
                catch (System.Exception)
                {
                    // log the error message
                    // terminate and persist the state of the workflow
                    throw;
                }
            }
        }
    }
}
