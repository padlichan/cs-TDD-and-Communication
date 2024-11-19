using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_TDD_and_Communication
{
    public class NumberManipulator
    {
        public static int SumMiddleNumbers(int[] numbers)
        {

            if(numbers.Length<3) return 0;

            Array.Sort(numbers);

            int endIndex = numbers.Length - 1;
            var output = numbers[1..endIndex];

            try
            {
            return output.Sum();

            }
            catch
            {
                throw new ArgumentException("Sum of elements in latger than maximum allowed for int32");
            }

        }
    }
}
