using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRedbeeAcademy
{
    class compareNumbers
    {

        public int Compare2Numbers(int n1, int n2)
        {
                if (n1 > n2)
                {
                return n1;
                }
                else
                {
                return n2;
                }

        }

        public int Compare3Numbers(int n1, int n2, int n3)
        {
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    return n1;
                }
                else
                {
                    return n3;
                }
            }
            else if (n2 > n3)
                return n2;
            else
                return n3;
        }
    }
}
