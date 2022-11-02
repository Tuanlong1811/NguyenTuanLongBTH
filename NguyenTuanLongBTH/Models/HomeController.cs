using Microsoft.AspNetCore.Mvc;

namespace NguyenTuanLongBTH.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
