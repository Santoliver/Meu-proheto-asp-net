using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noticias.BLL
{
    public class CategoriaBLL
    {
        private string _id;
        private string _descricao;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}
