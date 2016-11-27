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


        //Partição para quick
        public static int partition(int[] arr) {

            int left = 0;
            int right = arr.Count();
            int pivot = (left + right) / 2;


            while (true) {
                //Caminha do indice 0 para a direita, até encontrar um numero maior que o pivô
                while (arr[left] < pivot)
                    left++;

                //Caminha do indice final para a esquerda, até encontrar um numero menor que o pivô
                while (arr[right] > pivot)
                    right--;

                //se left e right nao se cruzarem, troca os numeros nas pos left e right entre si
                if (left > right) {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else{
                    return right;
                }
            }

        }

        


        public static void selectionSort(int[] arr) {



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
