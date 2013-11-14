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

        JaroWinklerDistance jw = new JaroWinklerDistance();
        Response.Write(jw.GetDistance(s1,s2));


        
    }
}