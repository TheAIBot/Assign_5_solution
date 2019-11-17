using System;
using System.Collections.Generic;

namespace Assign_5_solution
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int numbersCount = int.Parse(Console.ReadLine());
            //string numbersAsString = Console.ReadLine();
            //int[] numbers = new int[numbersCount];

            //int index = 0;
            //foreach (var split in numbersAsString.Split(' '))
            //{
            //    numbers[index++] = int.Parse(split);
            //}

            int[] numbers = new int[] { 7, 45, 2, 6, 2, 3, 8, 6, 2, 8 };
            var result = Solve(numbers);

            Console.WriteLine(result.number);
            Console.WriteLine(result.newNumber);
        }

        public static (int number, int newNumber) Solve(int[] numbers)
        {
            HashSet<int> sums = new HashSet<int>();
            Dictionary<int, HashSet<int>> sumLinks = new Dictionary<int, HashSet<int>>();
            bool[] usedNumbers = new bool[numbers.Length];
            Stack<int> sumNumbers = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!sumLinks.ContainsKey(numbers[i]))
                {
                    sumLinks[numbers[i]] = new HashSet<int>();
                }
            }

            for (int i = 1; i <= numbers.Length; i++)
            {
                //CreateAllSums(sums, sumLinks, numbers, usedNumbers, sumNumbers, 0, i);
                CreateAllSums(numbers, i, 0, 0, sums, sumLinks, sumNumbers);
            }

            //Console.WriteLine(sums.Count);
            //throw new Exception();

            int[] sumsArray = new int[sums.Count];
            sums.CopyTo(sumsArray);
            Array.Sort(sumsArray);

            return CreateCollisionAvoidanceArray(sumsArray, sumLinks, numbers);
        }

        private static void CreateAllSums(HashSet<int> sums, Dictionary<int, HashSet<int>> sumLinks, int[] numbers, bool[] usedNumbers, Stack<int> sumNumbers, int sum, int length)
        {
            if (sumNumbers.Count == length)
            {
                foreach (var num in sumNumbers)
                {
                    sumLinks[num].Add(sum);
                }

                sums.Add(sum);
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (usedNumbers[i])
                {
                    continue;
                }

                int newNumber = numbers[i];
                int newSum = sum + newNumber;

                usedNumbers[i] = true;
                sumNumbers.Push(newNumber);

                CreateAllSums(sums, sumLinks, numbers, usedNumbers, sumNumbers, newSum, length);

                sumNumbers.Pop();
                usedNumbers[i] = false;
            }
        }

        private static void CreateAllSums(int[] numbers, int length, int sum, int numberIndex, HashSet<int> sums, Dictionary<int, HashSet<int>> sumLinks, Stack<int> sumNumbers)
        {
            if (numberIndex == length)
            {
                foreach (var num in sumNumbers)
                {
                    sumLinks[num].Add(sum);
                }
                sums.Add(sum);
                return;
            }

            int newSum = sum + numbers[numberIndex];
            sumNumbers.Push(numbers[numberIndex]);

            CreateAllSums(numbers, length, sum + numbers[numberIndex], numberIndex + 1, sums, sumLinks, sumNumbers);

            sumNumbers.Pop();


            CreateAllSums(numbers, length, sum, numberIndex + 1, sums, sumLinks, sumNumbers);
        }

        private static (int number, int newNumber) CreateCollisionAvoidanceArray(int[] sortedSums, Dictionary<int, HashSet<int>> sumLinks, int[] numbers)
        {
            int maxCollisions = int.MinValue;
            foreach (var number in numbers)
            {
                maxCollisions = Math.Max(maxCollisions, sumLinks[number].Count);
            }

            List<(int number, int newNumber)> fwesa = new List<(int number, int newNumber)>();
            foreach (var number in numbers)
            {
                if (sumLinks[number].Count != maxCollisions)
                {
                    continue;
                }

                int maxLinkSum = number;

                int[] marked = new int[sortedSums[sortedSums.Length - 1] + 1];

                foreach (var sum in sumLinks[number])
                {
                    foreach (var num in sortedSums)
                    {
                        int index = maxLinkSum + (num - sum);
                        if (index >= 0)
                        {
                            marked[index]++;
                        }
                    }
                }

                int newBestIndex = -1;
                int bestCollisionsAvoided = int.MaxValue;
                for (int i = 0; i < marked.Length; i++)
                {
                    if (marked[i] < bestCollisionsAvoided)
                    {
                        newBestIndex = i;
                        bestCollisionsAvoided = marked[i];
                    }
                }

                fwesa.Add((number, newBestIndex));
            }

            int bestNumber = int.MaxValue;
            int bestNewNumber = int.MaxValue;

            foreach (var item in fwesa)
            {
                if (item.newNumber < 0)
                {
                    continue;
                }

                if (item.number < bestNumber)
                {
                    bestNumber = item.number;
                    bestNewNumber = item.newNumber;
                }
                else if (item.number == bestNumber)
                {
                    if (item.newNumber < bestNewNumber)
                    {
                        bestNumber = item.number;
                        bestNewNumber = item.newNumber;
                    }
                }
            }

            return (bestNumber, bestNewNumber);
        }
    }
}
