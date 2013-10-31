using System;
using System.Collections.Generic;
using System.Web;
using System.Text;
using System.Collections;


/// <summary>
/// Recommend 的摘要描述
/// </summary>
public class Recommend
{
	public Recommend(){}

    public double ManhattanDistance(Hashtable rating1,Hashtable rating2) {

        double distance = 0 ;

        foreach (string key in rating1) { 
            if(rating2.Contains(key)){
                distance +=Math.Abs((double)rating1[key] - (double)rating2[key]);
            }
        
        }

        return distance;
    }

    public double MinkowskiDistance(Hashtable rating1, Hashtable rating2, double r)
    {
        double distance = 0;
        bool commonRatings = false;

        foreach (string key in rating1)
        {
            if (rating2.Contains(key))
            {
                distance += Math.Pow(Math.Abs((double)rating1[key] - (double)rating2[key]), r);
                commonRatings = true;
            }
        }

        if (commonRatings)
            return Math.Pow(distance, 1/r);
        else
            return 0;

    }

}