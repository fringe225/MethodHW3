using System;

namespace MethodHW3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            //int[] arr = RandomArray();
            //Console.WriteLine("Unsorted array:  \n");
            //PrintArray(arr);
            //Console.WriteLine("Sorted array : \n");
            //arr = CustomSort(arr);

            //PrintArray(arr);
            #endregion

            #region task2


            //string[] arr_str = FillStringArray();
            //Console.Write("Axtardiginiz char elementini daxil edin - ");
            //char.TryParse(Console.ReadLine(), out char element);
            //Console.WriteLine();
            //PrintFind(arr_str, element);


            #endregion

        }


        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
        }
        static int[] RandomArray()
        {

            Console.Write("Arrayin size-ni daxil edin - ");
            int.TryParse(Console.ReadLine(), out int size);
            Console.WriteLine();

            int[] arr = new int[size];
            Random randInt = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randInt.Next(100);
            }

            return arr;
        }
        static int[] CustomSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if(arr[j] > arr[j + 1]) 
                    {
                        temp = arr[j]; 
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp; 
                    }
                }
            }

            return arr;
        }

        static string[] FillStringArray()
        {
            Console.Write("String Arrayin size-ni daxil edin - ");
            int.TryParse(Console.ReadLine(), out int size);
            Console.WriteLine();

            string[] arr = new string[size];
            for (int i = 0;i < arr.Length; i++)
            {
                Console.Write($"String Arrayinin {i}-ci elementini daxil edin: ");
                arr[i] = Console.ReadLine();
                Console.WriteLine();
            }

            return arr;
        }

        static void PrintFind(string[] arr_str,char find)
        {
            foreach (string item in arr_str)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == find)
                    {
                        Console.Write($"{item} ");
                        break;
                    }
                   
                       
                }
                
            }
        }



    }
}