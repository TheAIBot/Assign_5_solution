using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

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
            int[] numbers = new int[1000];
            Random rand = new Random(5263);
            for (int i = 0; i < numbers.Length; i++)
            {
                //numbers[i] = 20_000;
                numbers[i] = rand.Next(1, 20_001);
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

            public SumsData(List<int> newSums, HashSet<int> uniques)
            {
                this.NewSums = newSums;
                this.Uniques = uniques;
                this.Replications = newSums.Count - uniques.Count;
            }

            public SumsData(List<int> newSums, HashSet<int> uniques, int reps)
            {
                this.NewSums = newSums;
                this.Uniques = uniques;
                this.Replications = reps;
            }

            public override string ToString()
            {
                return $"new: {NewSums.Count}, Uniques: {Uniques.Count}";
            }
        }

        internal class BestSumsData
        {
            public readonly int Number;
            public readonly SumsData Data;

            public BestSumsData()
            {
                this.Data = new SumsData(null, null, int.MinValue);
            }

            public BestSumsData(int number, SumsData data)
            {
                this.Number = number;
                this.Data = data;
            }
        }

        public static (int number, int newNumber) Solve(int[] numbers)
        {
            Array.Sort(numbers);
            int maxCreated = -1;
            int[] sums = CreateAllSums(numbers, ref maxCreated);

            bool[] currSums = new bool[1];
            currSums[0] = true;

            HashSet<int> foundData = new HashSet<int>();
            BestSumsData bestData = new BestSumsData();
            int bestUniquesCount = int.MaxValue;
            int created = 0;
            CreateAllSumsDatas(numbers, currSums, foundData, ref bestData, ref bestUniquesCount, sums.Length, ref created, maxCreated);

            return CreateCollisionAvoidanceArray(sums, bestData);
        }

        private static void CreateAllSumsDatas(Span<int> numbers, bool[] currSums, HashSet<int> foundData, ref BestSumsData datas, ref int minuniques, int sumsCount, ref int created, int maxCreated)
        {
            if (numbers.Length > 1)
            {
                int midPoint = numbers.Length / 2;
                Span<int> firstPart = numbers.Slice(0, midPoint);
                Span<int> secondPart = numbers.Slice(midPoint);

                if (created > maxCreated)
                {
                    return;
                }

                bool[] secondPartSums = CreatePartialSums(secondPart, currSums);
                CreateAllSumsDatas(firstPart, secondPartSums, foundData, ref datas, ref minuniques, sumsCount, ref created, maxCreated);

                if (created > maxCreated)
                {
                    return;
                }

                bool[] firstPartSums = CreatePartialSums(firstPart, currSums);
                CreateAllSumsDatas(secondPart, firstPartSums, foundData, ref datas, ref minuniques, sumsCount, ref created, maxCreated);
            }
            else
            {
                created++;

                int actualSumCount = BoolArrayTrueCount(currSums);

                if (sumsCount - actualSumCount > minuniques)
                {
                    return;
                }

                int number = numbers[0];
                if (!foundData.Contains(number))
                {
                    BestSumsData newData = new BestSumsData(number, FinishCreateSumsData(number, currSums));

                    if (newData.Data.Replications > datas.Data.Replications ||
                        (newData.Data.Replications == datas.Data.Replications &&
                        newData.Number < datas.Number))
                    {
                        datas = newData;
                    }

                    minuniques = Math.Min(minuniques, datas.Data.Uniques.Count);
                }
            }
        }

        private static int BoolArrayTrueCount(bool[] array)
        {
            Span<byte> trueAsSpan = MemoryMarshal.Cast<bool, byte>(array);
            int trueCount = 0;
            for (int i = 0; i < trueAsSpan.Length; i++)
            {
                trueCount += trueAsSpan[i];
            }

            return trueCount;
        }

        private static bool[] CreatePartialSums(Span<int> numbers, bool[] currSums)
        {
            int maxSum = currSums.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                maxSum += numbers[i];
            }

            bool[] newSums = new bool[maxSum];
            currSums.CopyTo(newSums, 0);


            int prevMaxSum = currSums.Length - 1;
            for (int i = 0; i < numbers.Length; i++)
            {

                for (int z = prevMaxSum; z >= 0; z--)
                {
                    if (newSums[z])
                    {
                        newSums[z + numbers[i]] = true;
                    }
                }
                prevMaxSum += numbers[i];
            }

            return newSums;
        }

        private static SumsData FinishCreateSumsData(int number, bool[] currSums)
        {
            List<int> newSums = new List<int>();
            HashSet<int> uniques = new HashSet<int>();

            for (int i = 0; i < currSums.Length; i++)
            {
                if (currSums[i])
                {
                    int newSum = i + number;
                    if (newSum >= currSums.Length)
                    {
                        uniques.Add(newSum);
                    }
                    else if (!currSums[newSum])
                    {
                        uniques.Add(newSum);
                    }
                    newSums.Add(newSum);
                }
            }

            return new SumsData(newSums, uniques);
        }

        private static int[] CreateAllSums(int[] numbers, ref int index)
        {
            int maxSum = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                maxSum += numbers[i];
            }

            bool[] newSums = new bool[maxSum];
            newSums[0] = true;

            bool first = true;

            int prevMaxSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (first && newSums[numbers[i]])
                {
                    first = false;
                    index = i;
                }
                for (int z = prevMaxSum; z >= 0; z--)
                {
                    if (newSums[z])
                    {
                        newSums[z + numbers[i]] = true;
                    }
                }
                prevMaxSum += numbers[i];
            }

            int actualSumCount = BoolArrayTrueCount(newSums);
            int[] sums = new int[actualSumCount - 1];
            int sumsIndex = 0;
            for (int i = 1; i < newSums.Length; i++)
            {
                if (newSums[i])
                {
                    sums[sumsIndex++] = i;
                }
            }

            if (index == -1)
            {
                index = numbers.Length;
            }

            return sums;
        }

        private static (int number, int newNumber) CreateCollisionAvoidanceArray(int[] sortedSums, BestSumsData bestData)
        {
            SumsData sumData = bestData.Data;

            int highestSum = sortedSums[sortedSums.Length - 1] + 1;
            HashSet<int> filteredSums = new HashSet<int>();
            foreach (var sum in sortedSums)
            {
                if (sumData.Uniques.Contains(sum))
                {
                    continue;
                }
                filteredSums.Add(sum);
            }

            for (int i = 1; i <= highestSum; i++)
            {
                bool foundObstacle = false;
                foreach (var newSum in sumData.NewSums)
                {
                    int overlapIndex = newSum - (bestData.Number - i);
                    if (filteredSums.Contains(overlapIndex))
                    {
                        foundObstacle = true;
                        break;
                    }

                    int offset = 0;
                    while (filteredSums.Contains(overlapIndex + offset))
                    {
                        offset++;
                    }

                    i += offset;
                }

                if (!foundObstacle)
                {
                    return (bestData.Number, i);
                }
            }

            throw new Exception("impossible!.... i thought");
        }
    }
}
