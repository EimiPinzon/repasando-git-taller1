using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Taller1
{
    public partial class taller1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnimprimir_Click(object sender, EventArgs e)
        {
            int cap, porc, gan;
            cap = System.Convert.ToInt32(txtcapital.Text);
            porc = System.Convert.ToInt32(txtporcentaje.Text);
            gan = txtcapital * 0.02;


        }
    }
}