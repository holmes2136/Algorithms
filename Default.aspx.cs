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

        //Dictionary<string, double> dict = new Dictionary<string, double>();

        //dict.Add("test", 0.321);
        //dict.Add("test2", 0.33);

        //Bayes ba = new Bayes();
        //double val = ba.CalculateProb(dict);
        //Response.Write(val);

        int[] x = new int[] { 1, 2, 3, 4, 5, 7 };

        int[] y = new int[] { 1, 2, 3, 4, 5, 6 };
 

        var transpositions = x.Where((t, mi) => t != y[mi]).Count();

        Response.Write(transpositions);

    }
}