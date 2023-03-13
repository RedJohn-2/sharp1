using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input count row: ");
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = inputArray(n);

            Dictionary<int, int> amounts = getAmounts(matrix);

            outputAmounts(amounts);

            Console.ReadKey();

        }

        static int[][] inputArray(int n)
        {
            int[][] array = new int[n][];
            Console.WriteLine("Input elements: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }

            return array;
        }

        static Dictionary<int, int> getAmounts(int[][] matrix)
        {
            Dictionary<int, int> amounts = new Dictionary<int, int>();

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][i] % 2 == 0)
                {
                    amounts.Add(i, getAmountArray(matrix[i]));
                }
            }

            return amounts;
        }

        static int getAmountArray(int[] array)
        {
            int sum = 0;
            foreach (int el in array)
            {
                sum += el;
            }

            return sum;
        }

        static void outputAmounts(Dictionary<int, int> amounts)
        {
            foreach (int key in amounts.Keys)
            {
                Console.WriteLine("The amount of row №" + key + " = " + amounts[key]);
            }
        }
    }
}
