using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Binary
    {
        public static void Main()
        {
            //list Creation
            List<string> Geek = new List<string>();
            //list of element
            Geek.Add("ABCD");
            Geek.Add("QRST");
            Geek.Add("XYZ");
            Geek.Add("IJKL");
            Console.WriteLine("The original list is");
            foreach(string g in Geek)
            {
                //print orignal list
                Console.WriteLine(g);
            }
            Console.WriteLine("\nThe List in Sorted from");
            //sort the list
            Geek.Sort();

            Console.WriteLine();
            foreach(string g in Geek)
            {
                //print the sorted list
                Console.WriteLine(g);
            }
            Console.WriteLine("\nInsert EFGH :");

            // insert "EFGH" in the List
            //"EFGH" insert into its original
            // position when the List is sorted
            int index = Geek.BinarySearch("EFGH");

            if (index < 0)
            {
                Geek.Insert(~index, "EFGH");
            }
            Console.WriteLine();
            foreach(string g in Geek)
            {
                // prints the sorted list
                // after inserting "EFGH"
                Console.WriteLine(g);
            }
        }
    }
}
