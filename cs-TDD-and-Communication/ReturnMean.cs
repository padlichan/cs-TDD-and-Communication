using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_TDD_and_Communication
{
    public class ReturnMean
    {
        public static double CalculateMean(double[] input)
        {    
            if (input.Length == 0) throw new ArgumentException("cannot take an empty array as an argument");
            return input.Sum() / input.Length;
        }

        public static double CalculateMean(int[] input)
        {
            if (input.Length == 0) throw new ArgumentException("cannot take an empty array as an argument");
            return input.Sum() / input.Length;
        }
    }
}
