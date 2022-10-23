using System.Collections.Generic;
using System.Web.Mvc;
using AspNetModelExample.Models;

namespace AspNetModelExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { ProductId = 101, ProductName = "AC", Rate = 45000 },
                new Product() { ProductId = 102, ProductName = "Mobile", Rate = 38000 },
                new Product() { ProductId = 103, ProductName = "Bike", Rate = 94000 },
            };

            return View(products);
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        //public ActionResult CreatePost(int ProductId, string ProductName, double Rate)
        public ActionResult CreatePost(Product p)
        {
            return View();
        }
    }
}