using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteDotNetCoreMVC.BLL;

namespace TesteDotNetCoreMVC.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioBLL _UsuarioBLL { get; set; }

        public UsuarioController(UsuarioBLL usuarioBLL)
        {
            this._UsuarioBLL = usuarioBLL;
        }

        public IActionResult Index()
        {
            var usuarios = _UsuarioBLL.SelectAll();

            return View(usuarios);
        }
    }
}