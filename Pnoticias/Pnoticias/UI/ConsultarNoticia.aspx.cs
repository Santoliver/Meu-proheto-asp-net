using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pnoticias.UI
{
    public partial class ConsultarNoticia : System.Web.UI.Page
    {
        BLL.NoticiasBLL n = new BLL.NoticiasBLL();
        DAL.NoticiasDAL nDAL = new DAL.NoticiasDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                //Preencher a fonte/origem dos dados da GridView
                gvNoticias.DataSource = nDAL.Consultar();

                //"aplicar" os dados do lado do Cliente
                gvNoticias.DataBind();
            }

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {

            n.Titulo = txtFiltro.Text;
            gvNoticias.DataSource = nDAL.Consultar();
            gvNoticias.DataBind();
        }
        protected void gvNoticias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            n.Id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "cmdExcluir")
            {
                nDAL.Excluir(n);
                Response.Write("<script>alert('Descricao Excluida !')</script>");
                //Executa o clique via codigo do botao filtrar
                btnFiltrar_Click(null, null);
            }
            else if (e.CommandName == "cmdAtualizar")
            {
                //Redirecionar para a pagina Atualiza.aspx
                Response.Redirect("AtualizarCategoria.aspx?id=" + n.Id);
            }
        }
    }
}