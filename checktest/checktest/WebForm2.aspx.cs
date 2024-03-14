using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace checktest
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int no1 = Convert.ToInt32(Request.QueryString["number1"]);
            //int no2 = Convert.ToInt32(Request.QueryString["number2"]);
           // Response.Output.Write($"first no={no1} second no={no2}");

            HttpCookie c2 = Request.Cookies["data"];
            int numb1 = Convert.ToInt32(c2.Values["n1"]);
            int numb2 = Convert.ToInt32(c2.Values["n2"]);
            int res = numb1 + numb2;
            Response.Output.Write(res);

        }
    }
}