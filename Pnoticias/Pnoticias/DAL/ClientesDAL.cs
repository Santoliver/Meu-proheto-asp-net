using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Pnoticias.DAL
{
    public class ClientesDAL
    {
        Conexao con = new Conexao();
        public void Cadastrar(BLL.ClientesBLL c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO TBClientes(NOME, SOBRENOME, EMAIL, CPF, RG, CIDADE, BAIRRO, ENDERECO, UF, PROFISSAO) VALUES(@nome, @sobreNome, 
                                @email, @cpf, @rg, @cidade, @bairro, @endereco, @uf, @profissao)";

            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = c.Id_;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = c.Nome;
            cmd.Parameters.Add("@sobreNome", SqlDbType.VarChar).Value = c.Sobrenome;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = c.Email;
            cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = c.Cpf;
            cmd.Parameters.Add("@RG", SqlDbType.VarChar).Value = c.Rg;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = c.Cidade;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = c.Bairro;
            cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = c.Endereco;
            cmd.Parameters.Add("@UF", SqlDbType.VarChar).Value = c.Uf;
            cmd.Parameters.Add("@profissao", SqlDbType.VarChar).Value = c.Profissao;

            cmd.ExecuteNonQuery();
            con.Desconectar();


        }
    
    }
}