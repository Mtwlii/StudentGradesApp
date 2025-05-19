using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesApp
{
    internal class Average
    {
        public static double CalculateAverage(double[] grades)
        {
            double sum = 0;
            for (int i = 0; i < grades.Length; i++) 
            {
                sum += grades[i];
            }
            return sum / grades.Length; 
        }
    }
}
