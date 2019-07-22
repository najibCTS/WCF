using System.Collections.Generic;
using System.ServiceModel;

namespace _21_WCF_Assignment_01
{
    [ServiceContract]
    public interface IJobService
    {
        [OperationContract]
        List<string> OpeningJobs();

        [OperationContract]
        List<string> OpeningJobsByRole(string role);
    }
}
