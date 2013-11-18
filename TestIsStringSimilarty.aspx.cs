using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Algorithms;


public partial class TestIsStringSimilarty : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string s1 = "Holmes";
        string s2 = "Holmes2136";

        
        Response.Write(JaroWinklerDistance.GetDistance(s1,s2));

        Response.Write("<BR>");

        Response.Write(new LevenshteinDistance().GetDistance(s1,s2));

        Response.Write("<BR>");

       

    }
}