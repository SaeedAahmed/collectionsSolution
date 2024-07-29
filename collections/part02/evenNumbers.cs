using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.part02
{
    internal class EvenNumbers
    {
     public static ArrayList Even(ArrayList numbers)
        {
            ArrayList evenNumbers = new ArrayList();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }
    }
}
