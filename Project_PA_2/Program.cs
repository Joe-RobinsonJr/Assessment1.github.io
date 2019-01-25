using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PA_2
{
    class Program
    {
        static void Main(string[] args)
        {
              string Str = "";  //for storing string value

              Console.WriteLine("Type in your message below to see if its a Palindrome");
              Str = Console.ReadLine(); // taking information from file
              

              Console.WriteLine(Palindrome(Str)); // write reve
              Console.ReadKey();        // to keep window


        }

        static bool Palindrome(string input)
        {
              int Length;               //for counting lenght of given string
             string Revstr = "";

              Length = input.Length - 1;            //storing the length of given string

              while (Length >= 0)                //loops the given string length
              {

              Revstr = Revstr + input[Length];  //performimg a reverse string according to length of given string
              Length--;

              }

              if (Revstr != input)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
