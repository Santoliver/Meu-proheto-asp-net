using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pnoticias.BLL
{
    public class ClientesBLL 
    {
        private int id_;
        private string nome_;
        private string sobreNome_;
        private string Email_;
        private string CPF_;
        private string Rg_;
        private string Cidade_;
        private string Bairro_;
        private string Endereco_;
        private string Uf_;
        private string Profissao_;

        public int Id_
        {
            get { return id_; } set { id_ = value; }
        }
        public string Nome
        {
            get { return nome_; } set { nome_ = value; }
        }
        public string Sobrenome
        {
            get { return sobreNome_; } set { sobreNome_ = value; }
        }
        public string Email
        {
            get { return Email_;} set { Email_ = value; }
        }
        public string Cpf
        {
            get { return CPF_; } set { CPF_ = value; }
        } 
        public string Rg
        {
            get { return Rg_; } set { Rg_ = value; }
        }
     
        public string Cidade
        {
            get { return Cidade_; } set { Cidade_ = value; }
        }
        public string Bairro
        {
            get { return Bairro_; } set { Bairro_ = value; }
        }
        public string Endereco
        {
            get { return Endereco_; } set { Endereco_ = value; }
        }
        public string Uf
        {
            get { return Uf_; } set { Uf_ = value; }
        }
        public string Profissao
        {
            get { return Profissao_; } set { Profissao_ = value; }
        }
    }
}