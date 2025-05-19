using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesApp
{
    internal class Highest
    {
        public static double CalculateHighest(double[] grades)
        {
            double highest = grades[0];
            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > highest)
                {
                    highest = grades[i];
                }
            }
            return highest;
        }
    }
}
