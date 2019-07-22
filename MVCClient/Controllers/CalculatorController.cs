using System.Web.Mvc;

namespace MVCClient.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int num1, int num2, string operation)
        {
            int result = 0;
            CalculatorReference.CalculatorServiceClient client = new CalculatorReference.CalculatorServiceClient();
            switch (operation)
            {
                case "Add":
                    result = client.Add(num1, num2);
                    break;
                case "Sub":
                    result = client.Sub(num1, num2);
                    break;
                case "Multiply":
                    result = client.Multiply(num1, num2);
                    break;
                case "Divide":
                    result = client.Divide(num1, num2);
                    break;
            }
            ViewBag.Result = result;
            return View();
        }
    }
}