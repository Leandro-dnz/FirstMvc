using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeiraAPP_MVC4.Models
{
    public class Usuarios
    {
        public List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();
        public Usuarios()
        {
            listaUsuarios.Add(new UsuarioModel
            {
                nome = "Leandro ",
                sobrenome = " Diniz",
                endereco = "Rua Projetada , 100",
                email = "leandddro@outlook.com",
                nascimento = Convert.ToDateTime("06/05/1992")
            });
            
        }
        public void CriaUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuarios.Add(usuarioModelo);
        }
        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach (UsuarioModel usuario in listaUsuarios)
            {
                if (usuario.email == usuarioModelo.email)
                {
                    listaUsuarios.Remove(usuario);
                    listaUsuarios.Add(usuarioModelo);
                    break;
                }
            }
        }
        public UsuarioModel GetUsuario(string Email)
        {
            UsuarioModel _usuarioModel = null;

            foreach (UsuarioModel _usuario in listaUsuarios)
                if (_usuario.email == Email)
                    _usuarioModel = _usuario;

            return _usuarioModel;
        }
    }
}