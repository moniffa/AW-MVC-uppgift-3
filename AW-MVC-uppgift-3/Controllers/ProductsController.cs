using AW_MVC_uppgift_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACME.Controllers
{
    public class ProductsController : Controller
    {
        ProducsService service;
        public ProductsController()
        {
            service = ProducsService.getInstance();
        }
        [HttpGet("home"), HttpGet("index.html"), HttpGet("")]
        public IActionResult Index()
        {
            var model = service.GetAll();
            return View(model);
        }
    }
}
