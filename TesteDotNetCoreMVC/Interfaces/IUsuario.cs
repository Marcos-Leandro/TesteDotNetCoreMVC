using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDotNetCoreMVC.Interfaces
{
    public interface IUsuario
    {
        List<Models.Usuario> SelectAll();
        Models.Usuario SelectUsuarioByEmail(string email);
        Models.Usuario SelectUsuarioById(int id);
        int Insert(Models.Usuario usuario);
        bool Update(Models.Usuario usuario);
        bool Delete(int usuarioId);
    }
}
