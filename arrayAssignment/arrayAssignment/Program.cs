using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Array employee = Array.CreateInstance(typeof(string), 2, 3);

            employee.SetValue("3", 0, 0);
            employee.SetValue("2", 0, 1);
            employee.SetValue("4", 0, 2);


            employee.SetValue("martins", 1, 0);
            employee.SetValue("Victor", 1, 1);
            employee.SetValue("Aba", 1, 2);

            Console.WriteLine(employee.Rank);

    

            // Rank of an Array 

            int[] klass = new int[2];
            Console.WriteLine( klass.Rank);

            int[,] klass2 = new int[2, 3];
            int[, ,] klass3 = new int[2, 3, 4];

            Console.WriteLine(klass2.Rank);
            Console.WriteLine(klass3.Rank);
        }
    }
}
