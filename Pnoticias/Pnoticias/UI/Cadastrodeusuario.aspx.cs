using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pnoticias.UI
{
    public partial class Cadastrodeusuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL.UsuarioBLL u = new BLL.UsuarioBLL();
            DAL.UsuarioDAL uDAL = new DAL.UsuarioDAL();

            if (txtSenha1.Text != txtSenha2.Text)
            {
                Response.Write("<script>alert('Senha não confere !!')</script>");
            }
            else
            {
                u.Usuario = txtUsuarioLogin.Text;
                u.Senha = txtSenha1.Text;
                if (checkAdministrador.Checked)
                    u.Acesso = 1;
                else
                    u.Acesso = 0;

                uDAL.Cadastrar(u);
                Response.Write("<script>alert('Cadastro efetuado!')</script>");


            }

        }
    }
}