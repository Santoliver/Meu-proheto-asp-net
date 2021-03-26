﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace Pnoticias.DAL
{
    public class Conexao
    {
        SqlConnection con;
        public Conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-72DOD6B\SQLEXPRESS;Initial Catalog=BDNoticias;Integrated Security=True";
        }
        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            return con;
        }
        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}