using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

        internal readonly struct BitArrayIndices
        {
            internal readonly int ByteIndex;
            internal readonly int BitIndex;

            internal BitArrayIndices(int index)
            {
                ByteIndex = index >> 3;
                BitIndex = index & 0b0000_0111;
            }
        }

        internal class BitArraySlim
        {
            internal readonly byte[] Bytes;
            internal readonly int Length;

            internal BitArraySlim(int length)
            {
                this.Bytes = new byte[(length / 8) + 1];
                this.Length = length;
            }

            public byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    BitArrayIndices indices = new BitArrayIndices(index);
                    return (byte)((Bytes[indices.ByteIndex] >> indices.BitIndex) & 1);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal void OrSet(int index, byte val)
            {
                BitArrayIndices indices = new BitArrayIndices(index);
                Bytes[indices.ByteIndex] |= (byte)(val << indices.BitIndex);
            }

            internal void ForceSet(int index, byte val)
            {
                BitArrayIndices indices = new BitArrayIndices(index);
                Bytes[indices.ByteIndex] ^= (byte)((-val ^ Bytes[indices.ByteIndex]) & (1 << indices.BitIndex));
            }

            internal void CopyTo(BitArraySlim copyTo)
            {
                Array.Copy(Bytes, 0, copyTo.Bytes, 0, Bytes.Length);
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
            public BitArraySlim Sums;

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

            BitArraySlim currSums = new BitArraySlim(1);
            currSums.ForceSet(0, 1);

            PartialSumsData data = new PartialSumsData();
            data.MaxCreated = maxCreated;
            CreateAllSumsDatas(numbers, currSums, data);

            return CreateCollisionAvoidanceArray(data.Sums, data.Datas);
        }

        private static void CreateAllSumsDatas(Span<int> numbers, BitArraySlim currSums, PartialSumsData data)
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

                BitArraySlim secondPartSums = CreatePartialSums(secondPart, currSums);
                CreateAllSumsDatas(firstPart, secondPartSums, data);

                if (data.Created > data.MaxCreated)
                {
                    return;
                }

                BitArraySlim firstPartSums = CreatePartialSums(firstPart, currSums);
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

        private static int BoolArrayTrueCount(BitArraySlim array)
        {
            int trueCount = 0;

            Span<ulong> casted = MemoryMarshal.Cast<byte, ulong>(array.Bytes);
            for (int i = 0; i < casted.Length; i++)
            {
                trueCount += BitOperations.PopCount(casted[i]);
            }

            for (int i = casted.Length * 64; i < array.Length; i++)
            {
                trueCount += array[i];
            }

            return trueCount;
        }

        private static BitArraySlim CreatePartialSums(Span<int> numbers, BitArraySlim currSums)
        {
            int maxSum = currSums.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                maxSum += numbers[i];
            }

            BitArraySlim newSums = new BitArraySlim(maxSum);
            currSums.CopyTo(newSums);


            int prevMaxSum = currSums.Length - 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                AddNumberToSums(newSums, numbers[i], prevMaxSum);
                prevMaxSum += numbers[i];
            }

            return newSums;
        }

        private static SumsData FinishCreateSumsData(int number, BitArraySlim currSums)
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

        private static void CreateAllSums(int number, BitArraySlim currSums, PartialSumsData data)
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

            BitArraySlim newSums = new BitArraySlim(maxSum);
            newSums.ForceSet(0, 1);

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

        private static void AddNumberToSums(BitArraySlim sums, int number, int maxSum)
        {
            int z = maxSum;




            //for (; z >= Vector<byte>.Count; z -= Vector<byte>.Count)
            //{
            //    Vector<byte> left = new Vector<byte>(sums, z - Vector<byte>.Count + 1);
            //    Vector<byte> right = new Vector<byte>(sums, z - Vector<byte>.Count + number + 1);

            //    Vector<byte> result = (left | right);
            //    result.CopyTo(sums, z - Vector<byte>.Count + number + 1);
            //}

            z = TryCreateSumsVectorized64bit(sums, number, z);

            for (; z >= 0; z--)
            {
                sums.OrSet(z + number, sums[z]);
            }
        }



        private static unsafe int TryCreateSumsVectorized64bit(BitArraySlim sums, int number, int z)
        {
            if (z >= sizeof(ulong) * 8 * 2)
            {
                z -= sizeof(ulong) * 8;

                BitArrayIndices currSumIndices  = new BitArrayIndices(z);
                BitArrayIndices newSumIndices = new BitArrayIndices(z +number);

                fixed (byte* sumsPtr = sums.Bytes)
                {
                    ulong* currSumPtr = (ulong*)(sumsPtr + currSumIndices.ByteIndex + 1);
                    ulong* newSumPtr = (ulong*)(sumsPtr + newSumIndices.ByteIndex + 1);
                    switch (currSumIndices.BitIndex - newSumIndices.BitIndex)
                    {
                        case -7:
                        case -6:
                        case -5:
                        case -4:
                        case -3:
                        case -2:
                        case -1:
                            z = CreateSumsShiftLeft64bit(z, currSumPtr, newSumPtr, newSumIndices.BitIndex - currSumIndices.BitIndex);
                            break;
                        case 0:
                            z = CreateSumsNoShift64bit(z, currSumPtr, newSumPtr);
                            break;
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                            z = CreateSumsShiftRight64bit(z, currSumPtr, newSumPtr, currSumIndices.BitIndex - newSumIndices.BitIndex);
                            break;
                        default:
                            break;
                    }
                }

                z += sizeof(ulong) * 8;
            }

            return z;
        }

        private static unsafe int CreateSumsShiftLeft64bit(int z, ulong* currSumPtr, ulong* newSumPtr, int leftShift)
        {
            ulong nextSet = (*currSumPtr) << leftShift;
            do
            {
                ulong fromSum = nextSet;
                currSumPtr = (ulong*)(((byte*)currSumPtr) - (sizeof(ulong) - sizeof(byte)));
                nextSet = (*currSumPtr) << leftShift;

                *newSumPtr |= fromSum;
                newSumPtr = (ulong*)(((byte*)newSumPtr) - (sizeof(ulong) - sizeof(byte)));

                z -= ((sizeof(ulong) * 8) - (sizeof(byte) * 8));
            } while (z >= sizeof(ulong) * 8);
            *newSumPtr |= nextSet;

            z -= ((sizeof(ulong) * 8) - (sizeof(byte) * 8));
            return z;
        }

        private static unsafe int CreateSumsNoShift64bit(int z, ulong* currSumPtr, ulong* newSumPtr)
        {
            ulong nextSet = *currSumPtr;
            do
            {
                ulong fromSum = nextSet;
                currSumPtr = (ulong*)(((byte*)currSumPtr) - (sizeof(ulong) - sizeof(byte)));
                nextSet = *currSumPtr;

                *newSumPtr |= fromSum;
                newSumPtr = (ulong*)(((byte*)newSumPtr) - (sizeof(ulong) - sizeof(byte)));

                z -= ((sizeof(ulong) * 8) - (sizeof(byte) * 8));
            } while (z >= sizeof(ulong) * 8);
            *newSumPtr |= nextSet;

            z -= ((sizeof(ulong) * 8) - (sizeof(byte) * 8));
            return z;
        }

        private static unsafe int CreateSumsShiftRight64bit(int z, ulong* currSumPtr, ulong* newSumPtr, int rightShift)
        {
            ulong nextSet = (*currSumPtr) >> rightShift;
            do
            {
                ulong fromSum = nextSet;
                currSumPtr = (ulong*)(((byte*)currSumPtr) - (sizeof(ulong) - sizeof(byte)));
                nextSet = (*currSumPtr) >> rightShift;

                *newSumPtr |= fromSum;
                newSumPtr = (ulong*)(((byte*)newSumPtr) - (sizeof(ulong) - sizeof(byte)));

                z -= ((sizeof(ulong) * 8) - (sizeof(byte) * 8));
            } while (z >= sizeof(ulong) * 8);
            *newSumPtr |= nextSet;

            z -= ((sizeof(ulong) * 8) - (sizeof(byte) * 8));
            return z;
        }

        private static (int number, int newNumber) CreateCollisionAvoidanceArray(BitArraySlim sums, BestSumsData bestData)
        {
            SumsData sumData = bestData.Data;
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
