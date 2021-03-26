using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pnoticias.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAutenticar_Click(object sender, EventArgs e)
        {
            BLL.UsuarioBLL u = new BLL.UsuarioBLL();
            u.Usuario = txtLogin.Text;
            u.Senha = txtSenha.Text;

            DAL.UsuarioDAL uDAL = new DAL.UsuarioDAL();
            u = uDAL.Login(u);
            if (u.Usuario !="")
            {
                Response.Write("<script>alert('Bem vindo !')</script>");
                Session.Add("UsuarioLogado", u);
                Response.Redirect("Index.aspx");

            }
            else
            {
                Response.Write("<script>alert('Usuario ou senha invalido')</script>");
            }
        }
    }
}