using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.App.Home
{
    [Route("/")]
    public class HomeController: Controller
    {
        public async Task<IActionResult> Home()
        {
            return View();
        }
    }
}