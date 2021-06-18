using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRedbeeAcademy
{
    class sumArray
    {
        int sum = 0;
        List<int> arrayNumbers = new List<int>();

        public int SumArrayNumbers(List<int> arrayNumbers) {

            for (int i = 0; i < arrayNumbers.Count; i++)
            {
                sum += arrayNumbers[i];
            }
            return sum;
        }
    }
}
