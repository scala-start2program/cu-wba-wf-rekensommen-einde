using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wba.RekenSommen.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                GenereerGetallen();
            }
        }
        private void GenereerGetallen()
        {
            Random rnd = new Random();
            lblGetal1.Text = rnd.Next(1, 101).ToString();
            lblGetal2.Text = rnd.Next(1, 101).ToString();
            lblResultaatSom.CssClass = "form-control";
            lblResultaatSom.Text = "";
            txtSom.Text = "";
            txtSom.Focus();
        }
        protected void btnControleSom_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(lblGetal1.Text);
            int getal2 = int.Parse(lblGetal2.Text);
            int antwoord;
            int.TryParse(txtSom.Text, out antwoord);
            if (antwoord == getal1 + getal2)
            {
                lblResultaatSom.Text = "CORRECT";
                lblResultaatSom.CssClass = "form-control bg-success text-light";
            }
            else
            {
                lblResultaatSom.Text = "FOUT";
                lblResultaatSom.CssClass = "form-control bg-danger text-light";
            }
        }

        protected void lnkRefresh_Click(object sender, EventArgs e)
        {
            GenereerGetallen();
        }
    }
}


