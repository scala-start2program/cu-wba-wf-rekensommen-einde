using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wba.RekenSommen.Web
{
    public partial class Quotient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                GenereerGetallen();
            }
        }
        private void GenereerGetallen()
        {
            Random rnd = new Random();
            int getal1 = rnd.Next(3, 101);
            int getal2 = int.MaxValue;
            // we zorgen er voor dat getal1 deelbaar is door getal2
            while (getal1 % getal2 != 0)
            {
                getal2 = rnd.Next(1, 51);
            }
            lblGetal1.Text = getal1.ToString();
            lblGetal2.Text = getal2.ToString();
            lblResultaatQuotient.CssClass = "form-control";
            lblResultaatQuotient.Text = "";
            txtQuotient.Text = "";
            txtQuotient.Focus();
        }
        protected void btnControleQuotient_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(lblGetal1.Text);
            int getal2 = int.Parse(lblGetal2.Text);
            int antwoord;
            int.TryParse(txtQuotient.Text, out antwoord);
            if (antwoord == getal1 / getal2)
            {
                lblResultaatQuotient.Text = "CORRECT";
                lblResultaatQuotient.CssClass = "form-control bg-success text-light";
            }
            else
            {
                lblResultaatQuotient.Text = "FOUT";
                lblResultaatQuotient.CssClass = "form-control bg-danger text-light";
            }
        }
        protected void lnkRefresh_Click(object sender, EventArgs e)
        {
            GenereerGetallen();
        }
    }
}