using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pnoticias.UI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.UsuarioBLL u = new BLL.UsuarioBLL();

            if(Session["UsuarioLogado"] != null)
            {
                u = (BLL.UsuarioBLL)Session["UsuarioLogado"];
                if(u.Usuario != "")
                {
                    if(u.Acesso == 1)
                    {
                        btnCadDescricao.Enabled = true;
                        btnConCadastro.Enabled = true;
                        btnNoticia.Enabled = true;
                        btnConNoticia.Enabled = true;
                        
                        
                    }
                    else
                    {
                        btnConNoticia.Enabled = true;
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
                
            }
            else
                {
                    Response.Redirect("Login.aspx");
                }
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        protected void btnDescricao_Click(object sender, EventArgs e)
        {
            Response.Redirect("Descricao.aspx");
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Categoria.aspx");
        }

        protected void btnNoticia_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastronoticia.aspx");
        }

        protected void btnConsultarn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarNoticia.aspx");
        }

        protected void btncdpessoas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadfunc.aspx");
        }

    } 
}