using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AlgorithmPrograms
{
    internal class Insertion
    {
         
        public static void InsertSort(IComparable[] array)
        {
            int i, j;
            for (i = 0; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
        public static void xyz()
        {
            string[] name = { "vikaram", "Shubham", "Amol", "Jay Dip", "Manoj" };
            InsertSort(name);
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
