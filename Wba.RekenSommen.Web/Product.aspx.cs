using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wba.RekenSommen.Web
{
    public partial class Product : System.Web.UI.Page
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
            lblGetal1.Text = rnd.Next(1, 101).ToString();
            lblGetal2.Text = rnd.Next(1, 101).ToString();
            lblResultaatProduct.CssClass = "form-control";
            lblResultaatProduct.Text = "";
            txtProduct.Text = "";
            txtProduct.Focus();
        }
        protected void btnControleProduct_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(lblGetal1.Text);
            int getal2 = int.Parse(lblGetal2.Text);
            int antwoord;
            int.TryParse(txtProduct.Text, out antwoord);
            if (antwoord == getal1 * getal2)
            {
                lblResultaatProduct.Text = "CORRECT";
                lblResultaatProduct.CssClass = "form-control bg-success text-light";
            }
            else
            {
                lblResultaatProduct.Text = "FOUT";
                lblResultaatProduct.CssClass = "form-control bg-danger text-light";
            }
        }
        protected void lnkRefresh_Click(object sender, EventArgs e)
        {
            GenereerGetallen();
        }
    }
}