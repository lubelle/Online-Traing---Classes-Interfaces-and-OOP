namespace PropertyDemo
{
    public class EmailCampaignWorkFlow : IWorkFlowRepo
    {
        public void TaskRunner(WorkFlow workFlow)
        {
            System.Console.WriteLine("Email Campaign Work Flow");
        }
    }
}
