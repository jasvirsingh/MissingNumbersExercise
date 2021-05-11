using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var missingNumbers = FindMissingNumbers(new[] {3, 9, 15, 23, 45,67});
            Console.WriteLine(missingNumbers);
            Console.ReadLine();
        }

        private static string FindMissingNumbers(int[] input)
        {
            int[] numbers = new int[99];
            for (int i = 0; i < 99; i++)
            {
                numbers[i] = i + 1;
            }

            var inputArray = input.ToArray();
            var missingNumbers = new List<int>();
            numbers.ToList().ForEach(n =>
            {
                if (!inputArray.Contains(n))
                {
                    missingNumbers.Add(n);
                }
            });

            bool isHypen = false;
            var finalListOfMissingNumbers = new StringBuilder();

            for (int i = 0; i < missingNumbers.Count; i++)
            {

                if (i == missingNumbers.Count - 1)
                {
                    finalListOfMissingNumbers.Append(missingNumbers[i]);
                    break;
                }

                if (missingNumbers[i] + 1 == missingNumbers[i + 1])
                {
                    if (!isHypen)
                    {
                        isHypen = true;
                        finalListOfMissingNumbers.Append(missingNumbers[i] + "-");
                    }
                }
                else
                {
                    isHypen = false;
                    finalListOfMissingNumbers.Append(missingNumbers[i] + ",");
                }

            }

            return finalListOfMissingNumbers.ToString();
        }
    }
}
