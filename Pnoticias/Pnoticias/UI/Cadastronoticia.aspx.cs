using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pnoticias.UI
{
    public partial class Cadastronoticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL.CategoriaDAL cDAL = new DAL.CategoriaDAL();

                ddlCategoria.DataSource = cDAL.Consultar();
                ddlCategoria.DataTextField = "DESCRICAO";
                ddlCategoria.DataValueField = "ID";

                ddlCategoria.DataBind();
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL.NoticiasBLL n = new BLL.NoticiasBLL();
            DAL.NoticiasDAL nDAL = new DAL.NoticiasDAL();

            n.Titulo = txtTitulo.Text;
            n.Conteudo = txtConteudo.Text;
            n.Imagem = txtImagem.Text;

            n.IdCategoria = Convert.ToInt32(ddlCategoria.SelectedValue);

            nDAL.Cadastrar(n);
         
            Response.Write("<script>alert('Noticia Cadastrada')</script>");

            txtTitulo.Text = "";
            txtConteudo.Text = "";
            txtImagem.Text = "";
            ddlCategoria.SelectedIndex = 0;

            txtDescricao.Focus();  


        }
    }
}