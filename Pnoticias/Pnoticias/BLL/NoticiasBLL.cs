using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pnoticias.BLL
{
    public class NoticiasBLL
    {
        private int _id;
        private string _titulo;
        private string _conteudo;
        private string _imagem;
        private int _idCategoria;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public string Conteudo
        {
            get { return _conteudo; }
            set { _conteudo = value; }
        }
        public string Imagem
        {
            get { return _imagem; }
            set { _imagem = value; }
        }
        public int IdCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }
    }
}