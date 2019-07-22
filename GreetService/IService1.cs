using System.ServiceModel;

namespace GreetService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string SayHello(string name);

        [OperationContract]
        string TodayProgram(string name);
    }
}
