using System.Diagnostics;
using System.ServiceModel;

namespace PatternsLibrary.Structural.Proxy
{
    [ServiceContract]
    public interface ITestProxy
    {
        [OperationContract]
        void Test();
    }

    public class TestProxyClient : ClientBase<ITestProxy>, ITestProxy
    {
        public void Test()
        {
            Debug.WriteLine("TestProxyClient");
            Channel.Test();
        }
    }


}
