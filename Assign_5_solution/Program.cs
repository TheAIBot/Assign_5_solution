using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

            //int[] numbers = new int[] { 7, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 7, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 7, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23 };
            int[] numbers = new int[300];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }


            Console.WriteLine(numbers.Length);
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = Solve(numbers);
            watch.Stop();
            Console.WriteLine($"Time: {watch.ElapsedMilliseconds}");

            Console.WriteLine(result.number);
            Console.WriteLine(result.newNumber);
        }

        internal struct SumsData
        {
            public readonly List<int> NewSums;
            public readonly HashSet<int> Uniques;
            public readonly int Replications;

            public SumsData(List<int> newSums, HashSet<int> uniques, int replications)
            {
                this.NewSums = newSums;
                this.Uniques = uniques;
                this.Replications = replications;
            }

            public override string ToString()
            {
                return $"new: {NewSums.Count}, Uniques: {Uniques.Count}";
            }
        }

        public static (int number, int newNumber) Solve(int[] numbers)
        {
            Array.Sort(numbers);
            HashSet<int> sums = CreateAllSums(numbers);

            HashSet<int> currSums = new HashSet<int>();
            currSums.Add(0);

            Dictionary<int, SumsData> foundData = new Dictionary<int, SumsData>();
            CreateAllSumsDatas(numbers, currSums, foundData);

            SumsData[] numberSumsData = new SumsData[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numberSumsData[i] = foundData[numbers[i]];
            }

            int[] sumsArray = new int[sums.Count];
            sums.CopyTo(sumsArray);
            Array.Sort(sumsArray);

            return CreateCollisionAvoidanceArray(sumsArray, numbers, numberSumsData);
        }

        private static void CreateAllSumsDatas(Span<int> numbers, HashSet<int> currSums, Dictionary<int, SumsData> foundData)
        {
            if (numbers.Length > 1)
            {
                int midPoint = numbers.Length / 2;
                Span<int> firstPart = numbers.Slice(0, midPoint);
                Span<int> secondPart = numbers.Slice(midPoint);

                HashSet<int> firstPartSums = CreatePartialSums(firstPart, currSums);
                CreateAllSumsDatas(secondPart, firstPartSums, foundData);

                HashSet<int> secondPartSums = CreatePartialSums(secondPart, currSums);
                CreateAllSumsDatas(firstPart, secondPartSums, foundData);
            }
            else
            {
                int number = numbers[0];
                if (!foundData.ContainsKey(number))
                {
                    foundData.Add(number, FinishCreateSumsData(number, currSums));
                }
            }
        }

        private static HashSet<int> CreatePartialSums(Span<int> numbers, HashSet<int> currSums)
        {
            HashSet<int> oldSums = currSums;
            List<int> futureSums = new List<int>();
            bool first = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                futureSums.Clear();
                foreach (var sum in currSums)
                {
                    futureSums.Add(sum + numbers[i]);
                }
                futureSums.Add(numbers[i]);

                if (first)
                {
                    currSums = new HashSet<int>();
                    foreach (var sum in oldSums)
                    {
                        currSums.Add(sum);
                    }
                    first = false;
                }

                foreach (var sum in futureSums)
                {
                    currSums.Add(sum);
                }
            }

            return currSums;
        }

        private static SumsData FinishCreateSumsData(int number, HashSet<int> currSums)
        {
            List<int> newSums = new List<int>();
            HashSet<int> uniques = new HashSet<int>();
            int replications = 0;

            foreach (var sum in currSums)
            {
                int newSum = sum + number;
                if (!currSums.Contains(newSum))
                {
                    uniques.Add(newSum);
                }
                else
                {
                    replications++;
                }
                newSums.Add(newSum);
            }

            return new SumsData(newSums, uniques, replications);
        }

        private static HashSet<int> CreateAllSums(int[] numbers)
        {
            HashSet<int> currSums = new HashSet<int>();
            List<int> futureSums = new List<int>();

            currSums.Add(0);
            for (int i = 0; i < numbers.Length; i++)
            {
                futureSums.Clear();
                foreach (var sum in currSums)
                {
                    futureSums.Add(sum + numbers[i]);
                }
                futureSums.Add(numbers[i]);

                foreach (var sum in futureSums)
                {
                    currSums.Add(sum);
                }
            }
            //Console.WriteLine($"Sums: {currSums.Count}");
            return currSums;
        }

        private static (int number, int newNumber) CreateCollisionAvoidanceArray(int[] sortedSums, int[] numbers, SumsData[] numberSumsData)
        {
            int maxReplicas = int.MinValue;
            foreach (var data in numberSumsData)
            {
                maxReplicas = Math.Max(maxReplicas, data.Replications);
            }

            List<(int number, int newNumber, int diff)> fwesa = new List<(int number, int newNumber, int diff)>();
            int index = 0;
            foreach (var number in numbers)
            {
                if (numberSumsData[index].Replications != maxReplicas)
                {
                    index++;
                    continue;
                }

                int[] marked = new int[sortedSums[sortedSums.Length - 1] + 1];
                List<int> filteredSums = new List<int>();
                foreach (var sum in sortedSums)
                {
                    if (numberSumsData[index].Uniques.Contains(sum))
                    {
                        continue;
                    }
                    filteredSums.Add(sum);
                }

                int minIndex = 0;
                numberSumsData[index].NewSums.Sort();
                foreach (var repSum in numberSumsData[index].NewSums)
                {
                    for (int i = minIndex; i < filteredSums.Count; i++)
                    {
                        int sum = filteredSums[i];
                        int overlapIndex = (sum - repSum) + number;

                        if (overlapIndex < 0)
                        {
                            minIndex = i;
                            continue;
                        }

                        if (overlapIndex > marked.Length)
                        {
                            break;
                        }

                        marked[overlapIndex]++;
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

                fwesa.Add((number, newBestIndex, marked[number] - marked[newBestIndex]));
                index++;
            }

            int bestDiff = int.MinValue;
            int bestNumber = int.MaxValue;
            int bestNewNumber = int.MaxValue;

            foreach (var item in fwesa)
            {
                if (item.newNumber < 0)
                {
                    continue;
                }

                if (item.diff > bestDiff)
                {
                    bestDiff = item.diff;
                    bestNumber = item.number;
                    bestNewNumber = item.newNumber;
                }
                else if (item.diff == bestDiff)
                {
                    if (item.number < bestNumber)
                    {
                        bestDiff = item.diff;
                        bestNumber = item.number;
                        bestNewNumber = item.newNumber;
                    }
                    else if (item.number == bestNumber)
                    {
                        if (item.newNumber < bestNewNumber)
                        {
                            bestDiff = item.diff;
                            bestNumber = item.number;
                            bestNewNumber = item.newNumber;
                        }
                    }
                }
            }

            return (bestNumber, bestNewNumber);
        }
    }
}
