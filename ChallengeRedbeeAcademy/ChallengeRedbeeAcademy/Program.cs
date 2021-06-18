using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRedbeeAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            // SumArrayNumbers
            Console.WriteLine("Method that receives an array of numbers and returns the sum of each number");
            Random rand = new Random();
            List<int> numbers = new List<int>();

            for(int i = 0; i<5; i++)
            {
                numbers.Add(rand.Next(0, 50) + 1);
                Console.WriteLine("Item "+i+ " = "+ numbers[i]);
            }
            sumArray SumArrays = new sumArray();
            Console.WriteLine(SumArrays.SumArrayNumbers(numbers));

            // CompareArrayNumbers
            
            List<int> numbers2 = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numbers2.Add(rand.Next(0, 50) + 1);
                Console.WriteLine("Item " + i + " = " + numbers2[i]);
            }
            compareArray CompareArray = new compareArray();
            Console.WriteLine("Method that receives two lists and returns another list with de max of each index");
            CompareArray.CompareArrayNumbers(numbers, numbers2).ForEach(Console.WriteLine);

            //CompareNumbers

            //ACLARACION: Hice dos metodos porque, si bien el enunciado dice que recibe dos numeros, 
            //en el ejemplo el metodo recibia tres parametros

            Console.WriteLine("Method that receives two numbers and returns the max of both");

            compareNumbers CompareNumbers = new compareNumbers();
            Console.WriteLine(CompareNumbers.Compare2Numbers(5, 7));
            Console.WriteLine("Method that receives three numbers and returns the max");
          
            Console.WriteLine(CompareNumbers.Compare3Numbers(23, 10, 18));

            //SumTwoNumbers
            Console.WriteLine("Method that receives two numbers and returns the sum of both");

            sumNumbers SumNumbers = new sumNumbers();
            Console.WriteLine(SumNumbers.SumTwoNumbers(5, 7));
            Console.ReadKey();
        }


    }
}
