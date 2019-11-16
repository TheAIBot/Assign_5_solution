using System;
using System.Collections.Generic;

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

            var result = Solve(numbers);

            Console.WriteLine(result.number);
            Console.WriteLine(result.newNumber);
        }

        public static (int number, int newNumber) Solve(int[] numbers)
        {
            Dictionary<int, Node> sums = new Dictionary<int, Node>();
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
                CreateAllSums(sums, sumLinks, numbers, usedNumbers, sumNumbers, 0, i);
            }

            return CreateCollisionAvoidanceArray(sums, sumLinks, numbers);
        }

        internal class Node
        {
            public int Value;
            public Node Less;
            public Node More;
            public int Collisions;

            internal Node(int value)
            {
                this.Value = value;
                this.Less = null;
                this.More = null;
                this.Collisions = 0;
            }

            public int GetHowManyLess()
            {
                return Less == null ? 0 : Less.GetHowManyLess() + 1;
            }

            public int GetHowManyMore()
            {
                return More == null ? 0 : More.GetHowManyMore() + 1;
            }
        }

        private static void CreateAllSums(Dictionary<int, Node> sums, Dictionary<int, HashSet<int>> sumLinks, int[] numbers, bool[] usedNumbers, Stack<int> sumNumbers, int sum, int length)
        {
            if (sumNumbers.Count == length)
            {
                foreach (var num in sumNumbers)
                {
                    sumLinks[num].Add(sum);
                }

                Node sumNode;
                if (!sums.TryGetValue(sum, out sumNode))
                {
                    sumNode = new Node(sum);
                    sums[sum] = sumNode;
                }
                else
                {
                    sumNode.Collisions++;
                }

                if (sums.TryGetValue(sum - 1, out Node less))
                {
                    sumNode.Less = less;
                    less.More = sumNode;
                }

                if (sums.TryGetValue(sum + 1, out Node more))
                {
                    sumNode.More = more;
                    more.Less = sumNode;
                }
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

        private static (int number, int newNumber) CreateCollisionAvoidanceArray(Dictionary<int, Node> sums, Dictionary<int, HashSet<int>> sumLinks, int[] numbers)
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

                int maxLinksLess = 0;
                int maxLinksMore = 0;

                while (true)
                {
                    bool changed = false;
                    foreach (var sum in sumLinks[number])
                    {
                        int linksLess = 0;
                        int linksMore = 0;

                        if (sums.TryGetValue(sum - maxLinksLess, out Node lessNode))
                        {
                            linksLess = lessNode.GetHowManyLess();
                        }
                        if (sums.TryGetValue(sum + maxLinksMore, out Node moreNode))
                        {
                            linksMore = moreNode.GetHowManyMore();
                        }

                        if (linksLess > 0)
                        {
                            maxLinksLess += linksLess;
                            changed = true;
                        }
                        if (linksMore > 0)
                        {
                            maxLinksMore += linksMore;
                            changed = true;
                        }
                    }

                    if (!changed)
                    {
                        fwesa.Add((number, number - maxLinksLess));
                        fwesa.Add((number, number + maxLinksMore));
                        break;
                    }
                }
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
