using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace checktest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
           // int num1 = Convert.ToInt32(txttb1.Text);
           // int num2= Convert.ToInt32(txttb2.Text);
           // Response.Redirect($"WebForm2.aspx?number1={num1}&number2={num2}");


            HttpCookie c1 = new HttpCookie("Data");
            c1.Values["n1"] = txttb1.Text;
            c1.Values["n2"] = txttb2.Text;
            Response.Cookies.Add(c1);
            Response.Redirect("WebForm2.aspx");

        }
    }
}