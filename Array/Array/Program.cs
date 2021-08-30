using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Array
    {
        public int MaxItem (int[] arr)
        {
            int max = arr[0];
            foreach (var item in arr)
            {
                if(item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public int MinItem(int[] arr)
        {
            int min = arr[0];
            foreach (var item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        public int SumItems(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public void ReverseList (int[] arr)
        {
            Console.WriteLine("===================== REVERSED ARRAY ITEMS ===================== \n \n");
            for (int i = arr.Length; i > 0; i--)
            {
                Console.WriteLine(" => {0}", arr[i - 1]);
            }
        }

        public void List(int[] arr)  
        {
            Console.WriteLine("===================== ARRAY ITEMS ===================== \n \n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" => {0}", arr[i]);
            }
        }

    }
    class Program 
    {
        static void Main(string[] args)
        {
            var array = new Array();
            int[] numberArray = new int[10];


            //======= EXERCISE 1 --========================> Create Array 
            for (int i = 0; i < 10; i++)
            {
                numberArray[i] = i + 1;
            }

            array.List(numberArray);


            //======= EXERCISE 2 =============> Print Normal Ordered & Reverse Ordered Array 
            Console.Clear();
            array.List(numberArray);
            array.ReverseList(numberArray);


            //======= EXERCISE 3 --================> Sum All Items
            //Console.Clear();
            //array.List(numberArray);
            //Console.Write("\n \n SUM = {0}", array.SumItems(numberArray));


            //======= EXERCISE 4 --================> Find MIN And MAX
            //Console.Clear();
            //array.List(numberArray);

            //Console.WriteLine("\n \n MIN = {0}", array.MinItem(numberArray));
            //Console.WriteLine(" MAX = {0}", array.MaxItem(numberArray));

            //======== EXERCISE 5 --===================== > Fav Array
            var prefferedArray = new string[] { "Martins", "Cars", "Firms", "Family"}; 

            Console.ReadLine();
        }
    }
}
