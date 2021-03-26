using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pnoticias.UI
{
    public partial class Votos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

        protected void votos1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void BtnVoto_Click(object sender, EventArgs e)
        {

            BLL.VotosBLL v = new BLL.VotosBLL();
            DAL.VotosDAL cdal = new DAL.VotosDAL();

            if (rdVoto1.Checked)
            {
                Response.Write("Você votou em " + rdVoto1.Text + " < br /> ");
            }
            else if (rdVoto2.Checked)
            {
                Response.Write("Você votou em " + rdVoto3.Text + "<br/>");
            }
            else
            {
                Response.Write("Você votou em " + rdVoto3.Text + "<br/>");
            }
        }
        

        protected void Voto1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void Voto2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}