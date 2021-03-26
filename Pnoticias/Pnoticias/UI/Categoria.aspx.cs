using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pnoticias.UI
{
    public partial class Categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL.CategoriaBLL c = new BLL.CategoriaBLL();

            c.Descricao = txtDescricao.Text;

            DAL.CategoriaDAL cDAL = new DAL.CategoriaDAL();
            cDAL.Cadastrar(c);
            
            txtDescricao.Text = "";
            txtDescricao.Focus();

            }
        }
}