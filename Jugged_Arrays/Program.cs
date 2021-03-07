using System;

namespace Jugged_Arrays
{
    class Program
    {
        static void FillArray(int[][] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(1000); // diapason
                }
            }
        }

        static void ShowArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }
        }

        static void RowUp(int[][] arr,int count,int k)
        {
            for (int h = 0; h < count ; h++)
            {
                for (int i = 0; i < k / 2; i++)
                {
                    for (int j = (k-1-i);j>i; j--)
                    {
                        arr[k - j - 1][i] = arr[k - i - 1][k - j];
                    }
                }
            }
        }
        static void RowDown(int[][] arr,int count,int k)
        {
            for (int h = 0; h < count; h++)
            {
                for (int i = 0; i < k / 2; i++)
                {
                    for (int j = (k - 1 - i); j > i; j--)
                    {
                        arr[j][k - i - 1] = arr[j - 1][ k - i - 1];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[][] array = new int[3][];

            array[0] = new int[3];
            array[1] = new int[4];
            array[2] = new int[5];

            FillArray(array);
            ShowArray(array);

            Console.WriteLine("-----1-----");

            RowUp(array, 1, 2);
            ShowArray(array);

            Console.WriteLine("-----2-----");
            RowDown(array, 0, 0);
            ShowArray(array);
        }
    }
}
