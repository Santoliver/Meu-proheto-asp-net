using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pnoticias.UI
{
    public partial class Descricao : System.Web.UI.Page
    {
        BLL.CategoriaBLL Cat = new BLL.CategoriaBLL();
        DAL.CategoriaDAL cDAL = new DAL.CategoriaDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //Preencher a fonte/origem dos dados da GridView
                gvResultado.DataSource = cDAL.Consultar();

                //"aplicar" os dados do lado do Cliente
                gvResultado.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            Cat.Descricao = txtFiltro.Text;
            gvResultado.DataSource = cDAL.Consultar(Cat);
            gvResultado.DataBind();

        }
        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Cat.Id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "cmdExcluir")
            {
               cDAL.Excluir(Cat);
                Response.Write("<script>alert('Registro Excluido !')</script>");
                //Executa o clique via codigo do botao filtrar
                btnFiltrar_Click(null, null);
            }
            else if (e.CommandName == "cmdAtualizar")
            {
                //Redirecionar para a pagina Atualiza.aspx
                Response.Redirect("Descricao.aspx" + Cat.Id);
            }

        }
    }
}