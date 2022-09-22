using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class Twiner
    {

        public bool CheckTwins(string a, string b)
        {
            bool result = false;

            if ((a == null || b == null) || (a.Length != b.Length))
            {
                return result;
            }

            a = a.ToLower();
            b = b.ToLower();

            a = String.Concat(a.OrderBy(c => c));
            b = String.Concat(b.OrderBy(c => c));

            if (a == b)
            {
                result = true;
            }

            return result;
        }
    }
}
