using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesApp
{
    internal class lowest
    {
        public static double CalculateLowest(double[] grades)
        {
            double lowest = grades[0];
            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] < lowest)
                {
                    lowest = grades[i];
                }
            }
            return lowest;
        }
    }
}
