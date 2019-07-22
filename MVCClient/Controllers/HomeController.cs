using System.Linq;
using System.Web.Mvc;

namespace MVCClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Jobs()
        {
            ServiceReference1.JobServiceClient client = new ServiceReference1.JobServiceClient();
            ViewBag.List = client.OpeningJobs().ToList();
            return View();
        }

        [HttpPost]
        public ActionResult JobsByRole(string role)
        {
            ServiceReference1.JobServiceClient client = new ServiceReference1.JobServiceClient();
            ViewBag.List = client.OpeningJobsByRole(role).ToList();

            return View("Jobs");
        }
    }
}