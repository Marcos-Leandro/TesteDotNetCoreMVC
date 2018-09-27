using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteDotNetCoreMVC.Data;

namespace TesteDotNetCoreMVC.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly AppliationDbContext _appliationDbContext;

        public CategoriaController(AppliationDbContext appliationDbContext)
        {
            _appliationDbContext = appliationDbContext;
        }

        public IActionResult Index(int id)
        {
            var categorias = _appliationDbContext.Categoria.ToList();
            ViewBag.Categorias = categorias;

            var categoriaAtual = _appliationDbContext.Categoria.FirstOrDefault(f => f.Id == id);

            return View(categoriaAtual);
        }

        [HttpPost]
        public IActionResult Inserir(Models.Categoria categoria)
        {
            if (categoria.Id == 0)
            {
                _appliationDbContext.Categoria.Add(categoria);
            }
            else
            {
                var categoriaAtual = _appliationDbContext.Categoria.FirstOrDefault(f => f.Id == categoria.Id);
                categoriaAtual.Nome = categoria.Nome;
                _appliationDbContext.Categoria.Update(categoriaAtual);
            }
            _appliationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var categoriaAtual = _appliationDbContext.Categoria.FirstOrDefault(f => f.Id == id);
            _appliationDbContext.Categoria.Remove(categoriaAtual);
            _appliationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}