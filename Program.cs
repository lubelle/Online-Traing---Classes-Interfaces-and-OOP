using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new WorkFlowEngine();
            engine.RegisterWorkFlowRepo(new DigitalMarketingWorkFlow());
            engine.RegisterWorkFlowRepo(new EmailCampaignWorkFlow());

            engine.Run();

            Console.ReadLine();

        }
    }
}
