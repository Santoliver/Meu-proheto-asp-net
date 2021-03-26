using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace Pnoticias.DAL
{
    public class NoticiasDAL
    {
        Conexao con = new Conexao();
        public void Cadastrar(BLL.NoticiasBLL n)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO TBNoticia(
                                TITULO,
                                CONTEUDO,
                                IMAGEM,
                                ID_CATEGORIA)
                                VALUES(
                                @titulo,
                                @conteudo,
                                @imagem,
                                @id_categoria)";
            cmd.Parameters.AddWithValue("@titulo", n.Titulo);
            cmd.Parameters.AddWithValue("@conteudo", n.Conteudo);
            cmd.Parameters.AddWithValue("@imagem", n.Imagem);
            cmd.Parameters.AddWithValue("@id_categoria", n.IdCategoria);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
        public DataTable Consultar()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT TBNoticia.TITULO,TBNoticia.CONTEUDO,
TBNoticia.IMAGEM,TBNoticia.ID_CATEGORIA FROM TBNoticia INNER JOIN TBCategoria ON TBNoticia.ID = 
TBCategoria.ID", con.Conectar());

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
        public void Excluir(BLL.NoticiasBLL n)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM TBNoticia WHERE ID =@id";
            cmd.Parameters.AddWithValue("@id", n.Id);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}