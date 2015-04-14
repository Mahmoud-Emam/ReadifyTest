using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Host_Test_Service
{
    class Program
    {
        static void Main(string[] args)
        {

           using (ServiceHost host = new ServiceHost(typeof(redifyservice.RedPill)))
            {
                
                
 
                //Metadata Exchange
                ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
                serviceBehavior.HttpGetEnabled = true;
                //host.Description.Behaviors.Add(serviceBehavior);

                //Open
                host.Open();
                Console.WriteLine("Service is live now");
                Console.ReadKey();                

                
            
                Console.Read();
            }
        }
    }
}
