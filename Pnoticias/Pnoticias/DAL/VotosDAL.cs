using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Pnoticias.DAL
{
    public class VotosDAL
    {
        Conexao con = new Conexao();
        
        public void Cadastrar(BLL.VotosBLL v)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO TBVotos(VOTO1, VOTO2, VOTO3, TOTALVOTOS
                                        )VALUES(@voto1, @voto2, @voto3, @totalvotos)";

            cmd.Parameters.AddWithValue("@voto1", v.Voto1);
            cmd.Parameters.AddWithValue("@voto2", v.Voto2);
            cmd.Parameters.AddWithValue("@voto3", v.Voto3);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}