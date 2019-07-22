using System;

namespace MVCClient
{
    public class Service1 : IService1
    {
        public string SayHello(string name)
        {
            int hour = DateTime.Now.Hour;
            string greeting = string.Empty;
            if (hour > 16)
            {
                greeting = "Good Evening ";
            }
            else if (hour > 11)
            {
                greeting = "Good Afternoon ";
            }
            else
            {
                greeting = "Good Morning ";
            }
            return greeting + name;
        }

        public string TodayProgram(string name)
        {
            string day = DateTime.Now.DayOfWeek.ToString();
            string greeting = string.Empty;

            if (day.ToLower().Equals("saturday") || day.ToLower().Equals("sunday"))
            {
                greeting = "Happy weekend ";
            }
            else
            {
                greeting = "Enjoy Working day ";
            }
            return greeting + name;
        }
    }
}
