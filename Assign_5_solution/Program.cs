﻿using System;
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
            int numbersCount = int.Parse(Console.ReadLine());
            string numbersAsString = Console.ReadLine();
            int[] numbers = new int[numbersCount];

            int index = 0;
            foreach (var split in numbersAsString.Split(' '))
            {
                numbers[index++] = int.Parse(split);
            }

            //int[] numbers = new int[] { 7, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 7, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 7, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23, 23, 45, 2, 6, 2, 3, 8, 6, 2, 8, 45, 2, 6, 2, 3, 8, 6, 2, 8, 2, 6, 2, 56, 23, 65, 23 };
            //int[] numbers = new int[1000];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i;
            //}


            //Console.WriteLine(numbers.Length);
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            var result = Solve(numbers);
            //watch.Stop();
            //Console.WriteLine($"Time: {watch.ElapsedMilliseconds}");

            Console.WriteLine(result.number);
            Console.WriteLine(result.newNumber);
        }

        internal readonly struct SumsData
        {
            public readonly HashSet<int> Replicas;
            public readonly HashSet<int> Uniques;

            public SumsData(HashSet<int> replicas, HashSet<int> uniques)
            {
                this.Replicas = replicas;
                this.Uniques = uniques;
            }
        }

        public static (int number, int newNumber) Solve(int[] numbers)
        {
            Array.Sort(numbers);
            HashSet<int> sums = CreateAllSums(numbers);

            SumsData[] numberSumsData = new SumsData[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numberSumsData[i] = CreateAllSumsDataForIndex(numbers, i);
            }

            int[] sumsArray = new int[sums.Count];
            sums.CopyTo(sumsArray);
            Array.Sort(sumsArray);

            return CreateCollisionAvoidanceArray(sumsArray, numbers, numberSumsData);
        }
        
        private static SumsData CreateAllSumsDataForIndex(int[] numbers, int index)
        {
            int temp = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = numbers[index];
            numbers[index] = temp;

            var data = CreateAllSumsData(numbers);

            temp = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = numbers[index];
            numbers[index] = temp;

            return data;
        }

        private static SumsData CreateAllSumsData(int[] numbers)
        {
            HashSet<int> currSums = new HashSet<int>();
            List<int> futureSums = new List<int>();

            currSums.Add(0);
            for (int i = 0; i < numbers.Length - 1; i++)
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

            HashSet<int> replicas = new HashSet<int>();
            HashSet<int> uniques = new HashSet<int>();

            int lastNumber = numbers[numbers.Length - 1];
            foreach (var sum in currSums)
            {
                int newSum = sum + lastNumber;
                if (currSums.Contains(newSum))
                {
                    replicas.Add(newSum);
                }
                else
                {
                    uniques.Add(newSum);
                }
            }

            return new SumsData(replicas, uniques);
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
                maxReplicas = Math.Max(maxReplicas, data.Replicas.Count);
            }

            List<(int number, int newNumber, int diff)> fwesa = new List<(int number, int newNumber, int diff)>();
            int index = 0;
            foreach (var number in numbers)
            {
                if (numberSumsData[index].Replicas.Count != maxReplicas)
                {
                    index++;
                    continue;
                }

                int[] marked = new int[sortedSums[sortedSums.Length - 1] + 1];

                foreach (var repSum in numberSumsData[index].Replicas)
                {
                    foreach (var sum in sortedSums)
                    {
                        //if (numberSumsData[index].replicas.Contains(sum) || numberSumsData[index].uniques.Contains(sum))
                        //{
                        //    continue;
                        //}
                        if (numberSumsData[index].Uniques.Contains(sum))
                        {
                            continue;
                        }

                        int overlapIndex = (sum - repSum) + number;
                        if (overlapIndex == 61)
                        {

                        }
                        if (overlapIndex >= 0 && overlapIndex < marked.Length)
                        {
                            marked[overlapIndex]++;
                        }
                    }
                }

                foreach (var repSum in numberSumsData[index].Uniques)
                {
                    foreach (var sum in sortedSums)
                    {
                        if (numberSumsData[index].Uniques.Contains(sum))
                        {
                            continue;
                        }

                        int overlapIndex = (sum - repSum) + number;
                        if (overlapIndex == 61)
                        {

                        }
                        if (overlapIndex >= 0 && overlapIndex < marked.Length)
                        {
                            marked[overlapIndex]++;
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
