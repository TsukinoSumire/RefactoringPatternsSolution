using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;

namespace PatternsLibrary.Structural.Proxy
{

    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        int Test();
    }

    public class Service : IService
    {
        public int Test() => 1;
    }


    public class ServiceProxy
    {


        public void TestProxy()
        {
            string baseAddress = "http://localhost:9470/TestProxy";
            string netTcpAddress = "net.tcp://localhost:9471/TestProxy";
            var addressBase = new Uri[] { new Uri(baseAddress), new Uri(netTcpAddress) };
            using (ServiceHost host = new ServiceHost(typeof(Service), addressBase))
            {
                host.Open();
                var address = new EndpointAddress(netTcpAddress);
                using (ChannelFactory<IService> cf = new ChannelFactory<IService>(new NetTcpBinding(), address))
                { 

                    IService proxy = cf.CreateChannel();

                    var test = proxy.Test();
                    Console.WriteLine(test);
                }

                host.Close();
            }
        }       

    }


}
