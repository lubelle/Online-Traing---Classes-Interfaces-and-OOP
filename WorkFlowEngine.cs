using System.Collections;
using System.Collections.Generic;

namespace PropertyDemo
{
    public class WorkFlowEngine
    {
        private readonly IList<IWorkFlowRepo> _workFlowRepos;

        public WorkFlowEngine()
        {
            _workFlowRepos = new List<IWorkFlowRepo>();
        }

        public void Run()
        {
            foreach (var repo in _workFlowRepos)
            {
                repo.TaskRunner(new WorkFlow());
            }
        }

        public void RegisterWorkFlowRepo(IWorkFlowRepo repo)
        {
            _workFlowRepos.Add(repo);
        }
    }
}
