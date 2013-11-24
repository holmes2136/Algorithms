using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Algorithms;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(Math.Sqrt(5));

        Response.Write("<BR>");

        Response.Write(Math.Sqrt(9));
       

    }
}