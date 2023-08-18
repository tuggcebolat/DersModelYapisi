using DersModelYapisi.Models;
using DersModelYapisi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
    public class CardProductController : Controller
    {
        public IActionResult Index()
        {
            var product1 = new Product { Id = 1, Name = "Kamera", Price = 1400 };
            var product2 = new Product { Id = 2, Name = "Fotoğraf Makinesi", Price = 1500 };
            var product3 = new Product { Id = 3, Name = "Tripod", Price = 400 };

            var cartProduct1 = new CardProduct { Product = product1, Quantity = 5, Id = 1, price = 1400 };
            var cartProduct2 = new CardProduct { Product = product2, Quantity = 4, Id = 2, price = 1500 };
            var cartProduct3 = new CardProduct { Product = product3, Quantity = 3, Id = 3, price = 1700 };

            List<CardProduct> cardProducts = new List<CardProduct>();
            cardProducts.Add(cartProduct1);
            cardProducts.Add(cartProduct2);
            cardProducts.Add(cartProduct3);

            CardProductViewModel datas = new CardProductViewModel{  products= cardProducts };

            return View(datas);
        }
    }
}
