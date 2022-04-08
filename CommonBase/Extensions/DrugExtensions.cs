using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBase.Extensions
{
    public static partial class DrugExtensions
    {
        public static bool CheckNumber(string number)
        {
            var sum = 0;
            var res = 0;

            for (int i = 0; i < number.Length-1; i++)
            {
                sum += (number[i] - '0') * (i+1);
            }

            res = sum % 11;

            if (res == (number[9] - '0'))
                return true;

            if(res == 10 && number[9] == 'X')
                return true;

            return false;

        }
    }
}
