using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

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

        internal readonly struct PreSumsData
        {
            internal readonly BitArraySlim BitArray;
            internal readonly int Uniques;

            internal PreSumsData(BitArraySlim bits, int uniqs)
            {
                BitArray = bits;
                Uniques = uniqs;
            }

            internal PreSumsData(bool _)
            {
                BitArray = null;
                Uniques = int.MaxValue;
            }

            internal SumsData ToSumsData(int number, int totalSums)
            {
                List<int> newSums = new List<int>(totalSums);
                List<int> uniques = new List<int>(Uniques);

                for (int i = 0; i < BitArray.Length; i++)
                {
                    if (BitArray[i] == 1)
                    {
                        int newSum = i + number;
                        if (newSum >= BitArray.Length)
                        {
                            uniques.Add(newSum);
                        }
                        else if (BitArray[newSum] == 0)
                        {
                            uniques.Add(newSum);
                        }
                        newSums.Add(newSum);
                    }
                }

                return new SumsData(newSums, uniques);
            }
        }

        internal readonly struct BitArrayIndices
        {
            internal readonly int ByteIndex;
            internal readonly int BitIndex;

            internal BitArrayIndices(int index)
            {
                ByteIndex = index / BitCount<ulong>();
                BitIndex = index & (BitCount<ulong>() - 1);
            }
        }

        internal class BitArraySlim
        {
            internal readonly ulong[] Bytes;
            internal int Length;

            internal BitArraySlim(int length, int realLength)
            {
                int arrayLength = (realLength / BitCount<Vector256<byte>>()) + 2;
                arrayLength *= BitCount<Vector256<byte>>() / BitCount<ulong>();

                this.Bytes = new ulong[arrayLength];
                this.Length = length;
            }

            internal BitArraySlim(int length) : this(length, length)
            {
            }

            public ulong this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    BitArrayIndices indices = new BitArrayIndices(index);
                    return ((Bytes[indices.ByteIndex] >> indices.BitIndex) & 1);
                }
            }

            internal void ForceSet(int index, ulong val)
            {
                BitArrayIndices indices = new BitArrayIndices(index);
                Bytes[indices.ByteIndex] ^= (((ulong)(-(long)val) ^ Bytes[indices.ByteIndex]) & (1ul << indices.BitIndex));
            }

            internal void CopyToAndClearRest(BitArraySlim copyTo)
            {
                int copyLength = (Length / BitCount<ulong>()) + 1;
                int fillLength = copyTo.Bytes.Length - copyLength;
                Array.Copy(Bytes, 0, copyTo.Bytes, 0, copyLength);
                Array.Fill(copyTo.Bytes, 0ul, copyLength, fillLength);
            }

            internal void Reuse(int newLength)
            {
                Length = newLength;
            }
        }

        internal readonly struct BitArrayStorage
        {
            private readonly Stack<BitArraySlim> Arrays;
            private readonly int MaxSum;

            internal BitArrayStorage(int maxSum)
            {
                this.Arrays = new Stack<BitArraySlim>();
                this.MaxSum = maxSum;
            }

            internal BitArraySlim Pop(int length)
            {
                if (Arrays.Count == 0)
                {
                    return new BitArraySlim(length, MaxSum + 1);
                }
                else
                {
                    BitArraySlim arr = Arrays.Pop();
                    arr.Reuse(length);
                    return arr;
                }
            }

            internal void Push(BitArraySlim arr)
            {
                Arrays.Push(arr);
            }
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
            public readonly PreSumsData Data;

            public BestSumsData()
            {
                this.Data = new PreSumsData(false);
            }

            public BestSumsData(int number, PreSumsData data)
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
            public BitArraySlim Sums;
            public BitArrayStorage Storage;

            internal PartialSumsData(int maxSum)
            {
                FoundData = new HashSet<int>();
                Datas = new BestSumsData();
                Minuniques = int.MaxValue;
                SumsCount = -1;
                Created = 0;
                Sums = null;
                Storage = new BitArrayStorage(maxSum);
            }
        }

        public static (int number, int newNumber) Solve(int[] numbers)
        {
            Array.Sort(numbers);

            int maxSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                maxSum += numbers[i];
            }

            PartialSumsData data = new PartialSumsData(maxSum);

            BitArraySlim currSums = new BitArraySlim(1);
            currSums.ForceSet(0, 1);


            CreateAllSumsDatas(numbers, currSums, data);

            return CreateCollisionAvoidanceArray(data.Sums, data.Datas, data);
        }

        private static bool CreateAllSumsDatas(Span<int> numbers, BitArraySlim currSums, PartialSumsData data)
        {
            if (numbers.Length > 1)
            {
                int midPoint = numbers.Length / 2;
                Span<int> firstPart = numbers.Slice(0, midPoint);
                Span<int> secondPart = numbers.Slice(midPoint);

                BitArraySlim secondPartSums = CreatePartialSums(secondPart, currSums, data);
                if (!CreateAllSumsDatas(firstPart, secondPartSums, data))
                {
                    data.Storage.Push(secondPartSums);
                }

                BitArraySlim firstPartSums = CreatePartialSums(firstPart, currSums, data);
                if (!CreateAllSumsDatas(secondPart, firstPartSums, data))
                {
                    data.Storage.Push(firstPartSums);
                }
            }
            else
            {
                data.Created++;

                int actualSumCount = BoolArrayTrueCount(currSums);
                if (data.SumsCount - actualSumCount > data.Minuniques)
                {
                    return false;
                }

                int number = numbers[0];
                if (!data.FoundData.Contains(number))
                {
                    BestSumsData newData = new BestSumsData(number, FinishCreateSumsData(number, currSums, actualSumCount, data));
                    data.Minuniques = Math.Min(data.Minuniques, data.Datas.Data.Uniques);

                    if (newData.Data.Uniques < data.Datas.Data.Uniques ||
                        (newData.Data.Uniques == data.Datas.Data.Uniques &&
                            newData.Number < data.Datas.Number))
                    {
                        if (data.Datas.Data.BitArray != null)
                        {
                            data.Storage.Push(data.Datas.Data.BitArray);
                        }
                        data.Datas = newData;
                        return true;
                    }
                }
            }

            return false;
        }

        private static int BoolArrayTrueCount(BitArraySlim array)
        {
            int trueCount = 0;
            for (int i = 0; i < array.Bytes.Length; i++)
            {
                trueCount += BitOperations.PopCount(array.Bytes[i]);
            }

            return trueCount;
        }

        private static BitArraySlim CreatePartialSums(Span<int> numbers, BitArraySlim currSums, PartialSumsData data)
        {
            int maxSum = currSums.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                maxSum += numbers[i];
            }

            BitArraySlim newSums = data.Storage.Pop(maxSum);
            currSums.CopyToAndClearRest(newSums);


            int prevMaxSum = currSums.Length - 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                CreateSumsVectorized128bit(prevMaxSum, numbers[i], newSums);
                //CreateSumsVectorized64bit(prevMaxSum, numbers[i], newSums);
                prevMaxSum += numbers[i];
            }

            return newSums;
        }

        private static PreSumsData FinishCreateSumsData(int number, BitArraySlim currSums, int currSumsCount, PartialSumsData data)
        {
            if (data.SumsCount != -1)
            {
                int uniqueSums = data.SumsCount - currSumsCount;
                return new PreSumsData(currSums, uniqueSums);
            }

            if (data.SumsCount == -1)
            {
                CreateAllSums(number, currSums, data);
                data.SumsCount = BoolArrayTrueCount(data.Sums);
            }

            int uniques = 0;
            for (int i = 0; i < currSums.Length; i++)
            {
                if (currSums[i] == 1)
                {
                    int newSum = i + number;
                    if (newSum >= currSums.Length)
                    {
                        uniques++;
                    }
                    else if (currSums[newSum] == 0)
                    {
                        uniques++;
                    }
                }
            }

            return new PreSumsData(currSums, uniques);
        }

        private static void CreateAllSums(int number, BitArraySlim currSums, PartialSumsData data)
        {
            data.Sums = CreatePartialSums(new int[] { number }, currSums,  data);
            data.SumsCount = BoolArrayTrueCount(data.Sums);
        }

        private static unsafe int BitCount<T>() where T : unmanaged
        {
            return sizeof(T) * 8;
        }

        private static unsafe void CreateSumsVectorized128bit(int z, int number, BitArraySlim newSums)
        {
            BitArrayIndices numberOffset = new BitArrayIndices(number);

            int length = ((z + number) / BitCount<ulong>());
            fixed (ulong* arr = newSums.Bytes)
            {
                ulong* lastPtr = arr + length;
                ulong* currPtr = lastPtr - numberOffset.ByteIndex;

                int sizeFromUint = sizeof(Vector128<ulong>) / sizeof(ulong);
                int iterations = length - numberOffset.ByteIndex;
                int rest = iterations % sizeFromUint;
                iterations += rest;
                lastPtr += rest;
                currPtr += rest;

                if (numberOffset.BitIndex % BitCount<byte>() == 0)
                {
                    int offset = numberOffset.BitIndex / BitCount<byte>();
                    lastPtr = (ulong*)(((byte*)lastPtr) + offset);

                    for (int i = 0; i <= iterations; i += sizeFromUint)
                    {
                        Avx.Store(lastPtr - i, Avx.Or(Avx.LoadVector128(lastPtr - i), Avx.LoadVector128(currPtr - i)));
                    }
                }
                else
                {
                    for (int i = 1; i < iterations + 1; i += sizeFromUint)
                    {
                        Vector128<ulong> unalignedPart = Avx.LoadVector128(currPtr - i - 1);
                        Vector128<ulong> before = Avx.ShiftRightLogical(unalignedPart, (byte)(BitCount<ulong>() - numberOffset.BitIndex));
                        Vector128<ulong> after = Avx.ShiftLeftLogical(Avx.LoadVector128(currPtr - i), (byte)numberOffset.BitIndex);
                        Vector128<ulong> combined = Avx.Or(before, after);
                        Avx.Store(lastPtr - i, Avx.Or(Avx.LoadVector128(lastPtr - i), combined));
                    }

                    ulong affter = currPtr[-iterations] << numberOffset.BitIndex;
                    lastPtr[-iterations] |= affter;
                }
            }
        }

        private static unsafe void CreateSumsVectorized64bit(int z, int number, BitArraySlim newSums)
        {
            BitArrayIndices numberOffset = new BitArrayIndices(number);

            int length = ((z + number) / BitCount<ulong>());
            fixed (ulong* arr = newSums.Bytes)
            {
                ulong* lastPtr = arr + length;
                ulong* currPtr = lastPtr - numberOffset.ByteIndex;

                int iterations = length - numberOffset.ByteIndex;
                if (numberOffset.BitIndex % BitCount<byte>() == 0)
                {
                    int offset = numberOffset.BitIndex / BitCount<byte>();
                    lastPtr = (ulong*)(((byte*)lastPtr) + offset);

                    for (int i = 0; i <= iterations; i++)
                    {
                        lastPtr[-i] |= currPtr[-i];
                    }
                }
                else
                {
                    for (int i = 0; i < iterations; i++)
                    {
                        ulong before = currPtr[-i - 1] >> (BitCount<ulong>() - numberOffset.BitIndex);
                        ulong after = currPtr[-i] << numberOffset.BitIndex;
                        ulong combined = before | after;
                        lastPtr[-i] |= combined;
                    }

                    ulong affter = currPtr[-iterations] << numberOffset.BitIndex;
                    lastPtr[-iterations] |= affter;
                }
            }
        }

        private static (int number, int newNumber) CreateCollisionAvoidanceArray(BitArraySlim sums, BestSumsData bestData, PartialSumsData data)
        {
            SumsData sumData = bestData.Data.ToSumsData(bestData.Number, data.SumsCount);
            foreach (var unique in sumData.Uniques)
            {
                sums.ForceSet(unique, 0);
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
