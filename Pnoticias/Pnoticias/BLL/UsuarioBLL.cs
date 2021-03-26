using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pnoticias.BLL
{
    public class UsuarioBLL
    {
        private string _login_usuario;
        private string _senha;
        private int _acesso;

        public string Usuario
        {
            get { return _login_usuario; }
            set { _login_usuario = value; }
        }
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        public int Acesso
        {
            get { return _acesso; }
            set { _acesso = value; }
        }
    }
}