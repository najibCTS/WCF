using System.ServiceModel;

namespace _21_WCF_Assignment_01
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Add(int num1, int num2);
        [OperationContract]
        int Sub(int num1, int num2);
        [OperationContract]
        int Multiply(int num1, int num2);
        [OperationContract]
        int Divide(int num1, int num2);
    }
}
