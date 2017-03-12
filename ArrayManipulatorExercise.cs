using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulatorSolved
{
    class ArrayManipulatorExercise
    {
        static void Main(string[] args)
        {
            List<int> sequenceIn = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var command = input[0];
            var index = input[1];

            int[] numbers = new int[input.Length - 1];

            while (command != "print")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(input[i + 1]);  //
                }

                switch (command)
                {
                    case "add":
                        Add(numbers, sequenceIn);
                        break;
                    case "addMany":
                        AddRangeOfNumbers(numbers, sequenceIn);
                        break;
                    case "contains":
                        Contains(numbers, sequenceIn);
                        break;
                    case "remove":
                        Remove(numbers, sequenceIn);
                        break;
                    case "shift":
                        Shift(numbers, sequenceIn);
                        break;
                    case "sumPairs":
                        SumPairs(sequenceIn);
                        break;
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(" ", sequenceIn));

        }
        //*******************//
        static List<int> Add(int[] numbers, List<int> sequence)
        {
            sequence.Insert(numbers[0], numbers[1]);
            return sequence;
        }

        static List<int> AddRangeOfNumbers(int[] numbers, List<int> sequence)
        {
            sequence.InsertRange(numbers[0], numbers);
            return sequence;
        }

        static void Contains(int[] numbers, List<int> sequence)
        {
            var indexContains = 0;
            if (sequence.Contains(numbers[0]))
            {
                indexContains = sequence.IndexOf(numbers[0]);
            }
            else
            {
                indexContains = -1;
            }
            Console.WriteLine(indexContains);
        }

        static List<int> Remove(int[] numbers, List<int> sequence)
        {
            sequence.RemoveAt(numbers[0]);
            return sequence;
        }

        static List<int> Shift(int[] numbers, List<int> sequence)
        {
            for (int i = 0; i < numbers[0]; i++)
            {
                List<int> seqCloned = new List<int>();

                for (int j = 0; j < sequence.Count; j++)
                {
                    var position = (j + 1) % sequence.Count;
                    sequence[j] = seqCloned[position];
                }
            }
            return sequence;
        }

        static List<int> SumPairs(List<int> sequence)
        {
            int sum = 0;

            List<int> sumPairs = new List<int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                for (int j = i + 1; j < sequence.Count; j++)
                {
                    sum = sequence[i] + sequence[j];
                    sumPairs[i] = sum;
                }
            }
            sumPairs = sequence;

            return sequence;
        }
    }
}

