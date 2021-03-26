using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pnoticias.UI
{
    public partial class Cadfunc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
            }

        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {                    
                BLL.ClientesBLL c = new BLL.ClientesBLL();
                DAL.ClientesDAL CaDal = new DAL.ClientesDAL();

                c.Nome = txtNome.Text;
                c.Sobrenome = txtsobreNome.Text;
                c.Email = txtEmail.Text;
                c.Cpf = txtCpf.Text;
                c.Rg = txtRg.Text;
                c.Cidade = txtCidade.Text;
                c.Bairro = txtBairro.Text;
                c.Endereco = txtEndereco.Text;
                c.Uf = txtUf.Text;
                c.Profissao = txtProfissao.Text;

                CaDal.Cadastrar(c);

            Response.Write("<script>alert('Cadastro efetuado com sucesso')</script>");

                txtNome.Text ="";
                txtsobreNome.Text = "";
                txtEmail.Text="";
                txtCpf.Text="";
                txtRg.Text="";
                txtCidade.Text="";
                txtBairro.Text="";
                txtEndereco.Text="";
                txtUf.Text="";
                txtProfissao.Text="";

                

        }
           
    }
}
