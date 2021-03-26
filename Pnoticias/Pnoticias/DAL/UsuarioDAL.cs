using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace Pnoticias.DAL
{

    public class UsuarioDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.UsuarioBLL u)
        {
            BLL.Criptografia cripto = new BLL.Criptografia();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO TBUsuario(
                                    LOGIN_USUARIO
                                    ,SENHA
                                    ,NIVEL_ACESSO)
                             VALUES(
                                    @login_usuario,
                                    @senha,
                                    @nivel_acesso)";

            cmd.Parameters.AddWithValue("@login_usuario", u.Usuario);
            cmd.Parameters.AddWithValue("@senha", cripto.RetornaMD5(u.Senha));
            cmd.Parameters.AddWithValue("@nivel_acesso", u.Acesso);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
        public BLL.UsuarioBLL Login(BLL.UsuarioBLL u)

        {
            BLL.Criptografia cripto = new BLL.Criptografia();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT
                                     LOGIN_USUARIO
                                    ,SENHA
                                    ,NIVEL_ACESSO
                                FROM
                                    TBUsuario
                                WHERE
                                    LOGIN_USUARIO = @login
                                AND
                                    SENHA = @senha";
            cmd.Parameters.AddWithValue("@login", u.Usuario);
            cmd.Parameters.AddWithValue("@senha", cripto.RetornaMD5(u.Senha));

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                u.Usuario = dr["LOGIN_USUARIO"].ToString();
                u.Senha = dr["SENHA"].ToString();
                u.Acesso = Convert.ToInt32(dr["NIVEL_ACESSO"]);
                dr.Close();
            }
            else
            {
                u.Usuario = "";

            }
            con.Desconectar();
            return u;
        }
    }
}