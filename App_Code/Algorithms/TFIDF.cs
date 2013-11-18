using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace Algorithms
{
    /// <summary>
    /// TFIDF 的摘要描述
    /// </summary>
    public class TFIDF
    {
        public TFIDF() { }


        public double cosineSimilarity(double[] docVector1, double[] docVector2)
        {
            double dotProduct = 0.0;
            double magnitude1 = 0.0;
            double magnitude2 = 0.0;
            double cosineSimilarity = 0.0;

            for (int i = 0; i < docVector1.Length; i++)
            {
                dotProduct += docVector1[i] * docVector2[i];
                magnitude1 += Math.Pow(docVector1[i], 2);
                magnitude2 += Math.Pow(docVector2[i], 2);
            }

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