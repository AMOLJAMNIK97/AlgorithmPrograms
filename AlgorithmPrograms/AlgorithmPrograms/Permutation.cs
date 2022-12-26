using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Permutation
    {

        //Function for swapping the characters at position I with character at position j
        public static string SwapString(string a, int i, int j)
        {
            char[] b = a.ToCharArray();
            char ch;
            ch = b[i];
            b[i] = b[j];
            b[j] = ch;
            //Converting characters from array into single string
            return string.Join("", b);
            ;

        }
        public static void Main()
        {
            string str = "ABC";
            int len = str.Length;
            Console.WriteLine("All the permutations of the string are:");
            generatePermutation(str, 0, len);
        }

        //Function for generating different permutations of the string
        public static void generatePermutation(string str, int start, int end)
        {
            //Prints the permutations
            if (start == end - 1)
            {
                Console.WriteLine(str);
            }
            else
            {
                for(int i=start; i < end; i++)
                {

                    //Swapping the string by fixing a character  
                    str = SwapString(str, start, i);
                    //Recursively calling function generatePermutation() for rest of the characters   
                    generatePermutation(str, start + 1, end);
                    //Backtracking and swapping the characters again.  
                    str = SwapString(str, start, i);
                }
            }

        }
         
    }
}
