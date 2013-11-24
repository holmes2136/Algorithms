using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lucene.Net.Search;
using System.Collections;
using System.Collections.Generic;


namespace Algorithms
{
    /// <summary>
    /// TFIDF 的摘要描述
    /// </summary>
    public class TFIDF
    {
        public TFIDF() {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TotalNoun">所有的單字</param>
        /// <param name="docVector1">s1所有文字以及字頻</param>
        /// <param name="docVector2">s2所有文字以及字頻</param>
        /// <returns></returns>
        public double cosineSimilarity(List<string> TotalNoun, 
                                       Hashtable docVector1,
                                       Hashtable docVector2)
        {
     
            double dotProduct = 0.0;
            double magnitude1 = 0.0;
            double magnitude2 = 0.0;
            double cosineSimilarity = 0.0;

            for (int i = 0; i <= TotalNoun.Count -1; i++)
            {
                int x, y;
                
                if (docVector1.Contains(TotalNoun[i]))
                {
                    x = (int)docVector1[TotalNoun[i]];
                }
                else { 
                    x = 0 ;
                }

                if(docVector2.Contains(TotalNoun[i])){
                    y = (int)docVector2[TotalNoun[i]];
                }else{
                    y= 0 ;
                }
                
                dotProduct += x * y;
                magnitude1 += Math.Pow(x, 2);
                magnitude2 += Math.Pow(y, 2);              
           
            }

            //平方
            magnitude1 = Math.Sqrt(magnitude1);
            magnitude2 = Math.Sqrt(magnitude2);

            if (magnitude1 != 0.0 | magnitude2 != 0.0)
            {
                cosineSimilarity = dotProduct / (magnitude1 * magnitude2);
            }
            else
            {
                return 0.0;
            }
            return cosineSimilarity;
        }



        public double cosineSimilarity(List<double> docVector1, List<double> docVector2)
        {
            double dotProduct = 0.0;
            double magnitude1 = 0.0;
            double magnitude2 = 0.0;
            double cosineSimilarity = 0.0;

            int total = Math.Min(docVector1.Count, docVector2.Count) -1;

            for (int i = 0; i <= total; i++)
            {
                dotProduct += docVector1[i] * docVector2[i];

                //2^1 = 2
                magnitude1 += Math.Pow(docVector1[i], 2);
                magnitude2 += Math.Pow(docVector2[i], 2);
            }

            //平方
            magnitude1 = Math.Sqrt(magnitude1);
            magnitude2 = Math.Sqrt(magnitude2);

            if (magnitude1 != 0.0 | magnitude2 != 0.0)
            {
                cosineSimilarity = dotProduct / (magnitude1 * magnitude2);
            }
            else
            {
                return 0.0;
            }
            return cosineSimilarity;
        }

    }

}