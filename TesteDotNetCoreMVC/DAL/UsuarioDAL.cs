using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDotNetCoreMVC.Interfaces;
using TesteDotNetCoreMVC.Models;

namespace TesteDotNetCoreMVC.DAL
{
    public class UsuarioDAL : IUsuario
    {
        public bool Delete(int usuarioId)
        {
            return false;
        }

        public int Insert(Usuario usuario)
        {
            return 1;
        }

        public List<Usuario> SelectAll()
        {
            return new List<Usuario>();
        }

        public Usuario SelectUsuarioByEmail(string email)
        {
            return new Usuario();
        }

        public Usuario SelectUsuarioById(int id)
        {
            return new Usuario();
        }

        public bool Update(Usuario usuario)
        {
            return true;
        }
    }
}
