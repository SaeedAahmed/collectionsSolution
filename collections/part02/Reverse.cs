using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.reverse
{
     static class Reverse
    {
        public static void ReversaArrayList(ArrayList list)
        {
            
            for (int i = 0; i < list.Count/2; i++)
            {
                var temp = list[i];
                list[i] = list[list.Count-i-1];
                list[list.Count - i - 1] = temp;
            }
        }
    }
}
