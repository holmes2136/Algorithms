using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Bayes 
/// </summary>
public class Bayes
{

    public const int JointProbWordCount = 15;		

	public Bayes(){}



    /// <summary>
    /// Base on Bayes' theorem
    /// </summary>
    /// <param name="probs"></param>
    /// <returns></returns>
    /* Combine the 15 probabilities together into one.  
	* 
	*				abc          
	*	---------------------------
	*	abc + (1 - a)(1 - b)(1 - c)
	*
	*/
    public  double CalculateProb(Dictionary< string,double> probs){

        double mult = 1;  
        double comb = 1; 
        int index = 0;

        foreach (string keys in probs.Keys) {

            double prob = (double)probs[keys];
            mult = mult * prob;
            comb = comb * (1 - prob);

            if (++index > Bayes.JointProbWordCount)
                break;
        }
       
         return mult / (mult + comb);;

    }
}