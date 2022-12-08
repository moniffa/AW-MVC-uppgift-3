using Microsoft.AspNetCore.Mvc;

namespace ACME.Controllers
{
    public class ProductsController : Controller
    {

        public ProductsController()
        {

        }
        [HttpGet("home"), HttpGet("index.html"), HttpGet("")]
        public IActionResult Index()
        {

            return View();
        }
    }
}
