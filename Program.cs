using System.Linq;
using System;


namespace home
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // for (int i = 0; i < 15; i++)
            // {
            //    for (int k = 0; k < i; k++)
            //    {
            //      Console.Write('#');
            //    }
            //     Console.WriteLine();
            // }

            //////////////////////////////

            int[] x = { 1, 2, 4, 5 };

            char[] y = { 's', 'f' };

            string[] z = { "vlad", "petya" };

            //////////////////////////////

            int[] array = new int[] { 3, 55, 4, 34,55,23 }; // new int[] обов язково???

            // Index myIndex = new Index(1, true); // Аналогічно нижньому запису (Структура)// Як краще???

            //  Console.WriteLine(array[^1]); // Останній елемент массива

            // F5 - що відбувається?  
              
            // Для вилову помилок тільки Try/Catch?

            // Console.WriteLine(array[1..4]); //Вибрати окремі елементи массива

            int[] arr1 = { 2, 4, 67, 2, 5, 1, 6, 6, 2, 7, 94, 4, 22 };
            int[] arr = Enumerable.Repeat(4, 8).ToArray();

            int[] res2 = arr1.OrderBy(i => i).ToArray();  //i => i?? Стрілочна функція? //Сортування масива

            // Console.WriteLine(res2);

            int[] res = arr1.Distinct().ToArray(); //<< toarray? // Унікальні елементи

            // Console.WriteLine(res); //<<Вивести цілий массив як без цикла?

            // int st = Array.Find(arr1, i => i < 70);
            // Console.WriteLine(st);

            // Console.WriteLine(arr);  <<Вивести цілий массив як без цикла?

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.WriteLine(arr[i]);
            // }

            /////////////////////////////

            // Console.WriteLine("Array length?\n");

            // int arrLength = int.Parse(Console.ReadLine());

            // int[] newArr = new int[arrLength];
            // Console.WriteLine("Array elements?\n");


            // for (int i = 0; i < newArr.Length; i++)
            // {
            //     newArr[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // Console.WriteLine("\n");
            // Console.WriteLine("Your array:\n");

            // for (int k = 0; k < newArr.Length; k++)
            // {
            //     Console.Write($"{newArr[k]}\t");
            // }
            // Console.WriteLine("\n");

            ////////////////////////////////////////



            int[] arr2 = { 2, 4, 67, 2, 5, 1, 6, 6, 2, 7, 94, 4, 22 };

            // Console.WriteLine(arr2.Where(i => i % 2 == 0).Sum());

            // Console.WriteLine(arr2.Max());



            //    int sum = 0;

            //     for (int i = 0; i < arr2.Length; i++)
            //     {
            //         if (arr2[i] % 2 == 0)
            //         {
            //             sum = sum + arr2[i];
            //         }
            //     }
            //     Console.WriteLine(sum);


            /////////////////////////////////////
            // int minValue = arr2[0];

            // for (int q = 0; q < arr2.Length; q++)
            // {
            //     if(minValue > arr2[q])
            //     {
            //         minValue = arr2[q];
            //     }
            // }
            // Console.WriteLine(minValue);

            //////////////////////////////////


            // int[,] newArr =
            // {
            //     {12,4,5,2},
            //     {234,5,1,5},
            //     {39,5,21,4}
            // };

            // for (int i = 0; i < newArr.GetLength(0); i++)
            // {
            //     for (int j = 0; j < newArr.GetLength(1); j++)
            //     {
            //         Console.Write(newArr[i,j] + "  ");
            //     }
            //     Console.WriteLine();
            // }
            

            Random random = new Random();

            int newStr = random.Next(100);

            Console.WriteLine(newStr);

        }
    }
}
