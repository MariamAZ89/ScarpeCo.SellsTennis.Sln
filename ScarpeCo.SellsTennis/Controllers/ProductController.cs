using Microsoft.AspNetCore.Mvc;
using ScarpeCo.SellsTennis.Repositories;

namespace ScarpeCo.SellsTennis.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        // data
        var products = ProductRepository.GetProducts();
        return View(products);
    }

    public IActionResult Details(int id)
    {
        // data
        var product = ProductRepository.GetById(id);
        if (product is null)
            return NotFound();
        return View(product);
    }
}
