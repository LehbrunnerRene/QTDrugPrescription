using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBase.Extensions
{
    public static partial class PatientExtensions
    {
        public static bool CheckSSN(string SSN)
        {
            int[] weight = { 3, 7, 9, 0, 5, 8, 4, 2, 1, 6 };
            var res = 0;

            for (int i = 0; i < SSN.Length; i++)
            {
                res += i != 3 ? ((SSN[i]-'0') * weight[i]) : 0;

            }


            if (res % 11 == (SSN[3] - '0'))
                return true;

            return false;

        }
    }
}
