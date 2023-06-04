using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic.Arthimatic_Program
{
    internal class additionOfNumberUsingParams
    {
       
        public static int AddNumbers(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
               sum = sum + num;
            }
            return sum;

        }
    }
}
