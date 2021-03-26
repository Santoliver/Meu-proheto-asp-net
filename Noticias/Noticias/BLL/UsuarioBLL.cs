using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noticias.BLL
{
    public class UsuarioBLL
    {
        private string _id;
        private string _senha;
        private int _acesso;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
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
