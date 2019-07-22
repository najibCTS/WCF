using System.Web.Mvc;

namespace MVCClient.Controllers
{
    public class ServiceController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string protocol)
        {
            if (protocol == "http")
            {
                ServiceReference2.Service1Client httpClient = new ServiceReference2.Service1Client("BasicHttpBinding_IService1");
                ViewBag.Result = "http Call: " + httpClient.SayHello(name);
            }
            else if (protocol == "tcp")
            {
                ServiceReference2.Service1Client tcpClient = new ServiceReference2.Service1Client("NetTcpBinding_IService1");
                ViewBag.Result = "tcp Call: " + tcpClient.SayHello(name);
            }
            return View();
        }
    }
}