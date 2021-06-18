using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRedbeeAcademy
{
    class compareArray
    {
        List<int> l1 = new List<int>();
        List<int> l2 = new List<int>();
        List<int> l3 = new List<int>();

        public List<int> CompareArrayNumbers(List<int>l1, List<int> l2)
        {

            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i] > l2[i])
                {
                    l3.Add(l1[i]);
                }
                else
                {
                    l3.Add(l2[i]);
                }
            }
            return l3;
        }
    }
}
