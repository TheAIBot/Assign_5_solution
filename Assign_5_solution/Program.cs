using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

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
            //Random rand = new Random(5263);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //numbers[i] = 20_000;
            //    numbers[i] = rand.Next(1, 20_001);
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

        internal struct SumsData
        {
            public readonly List<int> NewSums;
            public readonly List<int> Uniques;
            public readonly int Replications;

            public SumsData(List<int> newSums, List<int> uniques)
            {
                this.NewSums = newSums;
                this.Uniques = uniques;
                this.Replications = newSums.Count - uniques.Count;
            }

            public SumsData(List<int> newSums, List<int> uniques, int reps)
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

        internal class PartialSumsData
        {
            public HashSet<int> FoundData;
            public BestSumsData Datas;
            public int Minuniques;
            public int SumsCount;
            public int Created;
            public int MaxCreated;
            public byte[] Sums;

            internal PartialSumsData()
            {
                FoundData = new HashSet<int>();
                Datas = new BestSumsData();
                Minuniques = int.MaxValue;
                SumsCount = -1;
                Created = 0;
                Sums = null;
            }
        }

        public static (int number, int newNumber) Solve(int[] numbers)
        {
            Array.Sort(numbers);
            int maxCreated = GetFirstReplicateIndex(numbers);

            byte[] currSums = new byte[1];
            currSums[0] = 1;

            PartialSumsData data = new PartialSumsData();
            data.MaxCreated = maxCreated;
            CreateAllSumsDatas(numbers, currSums, data);

            return CreateCollisionAvoidanceArray(data.Sums, data.Datas);
        }

        private static void CreateAllSumsDatas(Span<int> numbers, byte[] currSums, PartialSumsData data)
        {
            if (numbers.Length > 1)
            {
                int midPoint = numbers.Length / 2;
                Span<int> firstPart = numbers.Slice(0, midPoint);
                Span<int> secondPart = numbers.Slice(midPoint);

                if (data.Created > data.MaxCreated)
                {
                    return;
                }

                byte[] secondPartSums = CreatePartialSums(secondPart, currSums);
                CreateAllSumsDatas(firstPart, secondPartSums, data);

                if (data.Created > data.MaxCreated)
                {
                    return;
                }

                byte[] firstPartSums = CreatePartialSums(firstPart, currSums);
                CreateAllSumsDatas(secondPart, firstPartSums, data);
            }
            else
            {
                data.Created++;

                int actualSumCount = BoolArrayTrueCount(currSums);
                if (data.SumsCount - actualSumCount > data.Minuniques)
                {
                    return;
                }

                int number = numbers[0];
                if (!data.FoundData.Contains(number))
                {
                    BestSumsData newData = new BestSumsData(number, FinishCreateSumsData(number, currSums));

                    if (newData.Data.Replications > data.Datas.Data.Replications ||
                        (newData.Data.Replications == data.Datas.Data.Replications &&
                        newData.Number < data.Datas.Number))
                    {
                        data.Datas = newData;
                    }

                    if (data.SumsCount == -1)
                    {
                        CreateAllSums(number, currSums, data);
                    }

                    data.Minuniques = Math.Min(data.Minuniques, data.Datas.Data.Uniques.Count);
                }
            }
        }

        private static int BoolArrayTrueCount(byte[] array)
        {
            int trueCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                trueCount += array[i];
            }

            return trueCount;
        }

        private static byte[] CreatePartialSums(Span<int> numbers, byte[] currSums)
        {
            int maxSum = currSums.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                maxSum += numbers[i];
            }

            byte[] newSums = new byte[maxSum];
            currSums.CopyTo(newSums, 0);


            int prevMaxSum = currSums.Length - 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                AddNumberToSums(newSums, numbers[i], prevMaxSum);
                prevMaxSum += numbers[i];
            }

            return newSums;
        }

        private static SumsData FinishCreateSumsData(int number, byte[] currSums)
        {
            List<int> newSums = new List<int>();
            List<int> uniques = new List<int>();

            for (int i = 0; i < currSums.Length; i++)
            {
                if (currSums[i] == 1)
                {
                    int newSum = i + number;
                    if (newSum >= currSums.Length)
                    {
                        uniques.Add(newSum);
                    }
                    else if (currSums[newSum] == 0)
                    {
                        uniques.Add(newSum);
                    }
                    newSums.Add(newSum);
                }
            }

            return new SumsData(newSums, uniques);
        }

        private static void CreateAllSums(int number, byte[] currSums, PartialSumsData data)
        {
            data.Sums = CreatePartialSums(new int[] { number }, currSums);
            data.SumsCount = BoolArrayTrueCount(data.Sums);
        }

        private static int GetFirstReplicateIndex(int[] numbers)
        {
            int maxSum = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                maxSum += numbers[i];
            }

            byte[] newSums = new byte[maxSum];
            newSums[0] = 1;

            int prevMaxSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (newSums[numbers[i]] == 1)
                {
                    return i;
                }
                AddNumberToSums(newSums, numbers[i], prevMaxSum);
                prevMaxSum += numbers[i];
            }

            return numbers.Length;
        }

        private static void AddNumberToSums(byte[] sums, int number, int maxSum)
        {
            int z = maxSum;
            for (; z >= Vector<byte>.Count; z -= Vector<byte>.Count)
            {
                Vector<byte> left = new Vector<byte>(sums, z - Vector<byte>.Count + 1);
                Vector<byte> right = new Vector<byte>(sums, z - Vector<byte>.Count + number + 1);

                Vector<byte> result = (left | right);
                result.CopyTo(sums, z - Vector<byte>.Count + number + 1);
            }
            for (; z >= 0; z--)
            {
                sums[z + number] |= sums[z];
            }
        }

        private static (int number, int newNumber) CreateCollisionAvoidanceArray(byte[] sums, BestSumsData bestData)
        {
            SumsData sumData = bestData.Data;
            foreach (var unique in sumData.Uniques)
            {
                sums[unique] = 0;
            }

            for (int i = 1; i <= sums.Length;)
            {
                bool foundObstacle = false;
                foreach (var newSum in sumData.NewSums)
                {
                    int overlapIndex = newSum - (bestData.Number - i);
                    int offset = 0;
                    while (overlapIndex + offset < sums.Length && sums[overlapIndex + offset] == 1)
                    {
                        offset++;
                    }

                    i += offset;
                    if (offset > 0)
                    {
                        foundObstacle = true;
                        break;
                    }
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
