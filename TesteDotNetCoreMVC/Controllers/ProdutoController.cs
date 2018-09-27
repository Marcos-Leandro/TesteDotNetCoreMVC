using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TesteDotNetCoreMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Save(Models.Produto produto)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.Validacao = "Produto inválido";
            }

            return View();
        }
    }
}