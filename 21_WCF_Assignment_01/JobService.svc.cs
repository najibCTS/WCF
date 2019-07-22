using System.Collections.Generic;

namespace _21_WCF_Assignment_01
{
    public class JobService : IJobService
    {
        public List<string> OpeningJobs() => new List<string>() { "Web Developer", "DBA", "Scrum Master", "Business Analyst" };

        public List<string> OpeningJobsByRole(string role)
        {
            List<string> jobs = new List<string>();
            switch (role.ToLower())
            {
                case "junior":
                    jobs = new List<string> { "System Engineer", "Intern", "Assistant" };
                    break;
                case "middle":
                    jobs = new List<string> { "Senior System Engineer", "UI developer", "Full Stack Engineer" };
                    break;
                default:
                    jobs= new List<string>() { "Web Developer", "DBA", "Scrum Master", "Business Analyst" };
                    break;
            }
            return jobs;
        }
    }
}
