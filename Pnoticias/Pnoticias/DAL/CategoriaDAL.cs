using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace Pnoticias.DAL
{
    public class CategoriaDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.CategoriaBLL c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO TBCategoria(
                                DESCRICAO)VALUES(@descricao)";

            cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = c.Descricao;

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
        public DataTable Consultar()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT ID,DESCRICAO FROM TBCategoria";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
        public DataTable Consultar(BLL.CategoriaBLL c)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT ID,DESCRICAO FROM TBCategoria
                                WHERE DESCRICAO LIKE @descricao";
            cmd.Parameters.AddWithValue("@descricao", "%" + c.Descricao+"%");

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            da.Fill(dt);
            con.Desconectar();
            return dt;
        }
        public void Atualizar(BLL.CategoriaBLL c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE TBCategoria
                                SET 
                                    DESCRICAO   = @descricao
                                    WHERE 
                                    ID          = @id";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@descricao", c.Descricao);

            cmd.ExecuteNonQuery();
            con.Desconectar();

        }
        
        public void Excluir(BLL.CategoriaBLL c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM TBCategoria 
                                WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
        
    }
}