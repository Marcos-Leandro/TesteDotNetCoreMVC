using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDotNetCoreMVC.Interfaces;

namespace TesteDotNetCoreMVC.BLL
{
    public class UsuarioBLL
    {
        private IUsuario _Usuario { get; set; }

        public UsuarioBLL(IUsuario usuario)
        {
            this._Usuario = usuario;
        }

        public List<Models.Usuario> SelectAll()
        {
            return _Usuario.SelectAll();
        }

        public Models.Usuario SelecionarPorEmail(string email)
        {
            return _Usuario.SelectUsuarioByEmail(email);
        }

        public Models.Usuario SelecionarPorEmail(int id)
        {
            return _Usuario.SelectUsuarioById(id);
        }

        public int Insert(Models.Usuario usuario)
        {
            return _Usuario.Insert(usuario);
        }

        public bool Update(Models.Usuario usuario)
        {
            return _Usuario.Update(usuario);
        }

        public bool Delete(int id)
        {
            return _Usuario.Delete(id);
        }
    }
}
