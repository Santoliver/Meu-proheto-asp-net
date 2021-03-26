using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pnoticias.BLL
{
    public class CategoriaBLL
    {
        private int _id;
        private string _descricao;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string Cadastrar { get; internal set; }
    }
}