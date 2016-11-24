using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {

        public static void bubbleSort(int[] arr) {

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();


        }



        public static void Main(string[] args)
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };


            int sort;


            Console.WriteLine("Informe o sort que deseja utilizar: ");
            sort = int.Parse(Console.ReadLine());

            switch (sort)
            {
                case 1:
                    bubbleSort(arr);                   
                    break;


                default:
                    Console.Write("Opção Inválida!");
                    break;
            }
        }
    }
}
