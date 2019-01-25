using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PA_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0;
            string userinput = "";
            string addstring = "";
            bool arrayfin = false;
            while (arrayfin == false)
            {
                Console.WriteLine("Input either 1 or 0, anything else will exit");
                userinput = Console.ReadLine();
                if (userinput == "0")
                {
                    addstring = addstring + "0";
                    Number++;
                }else if (userinput == "1")
                {
                    addstring = addstring + "1";
                    Number++;
                }
                else
                {
                    arrayfin = true;
                }
            }
            Console.Clear();
            int[] Arraystring = new int[Number];

            for (int i = 0; i < addstring.Length; i++)
            {
                if (addstring[i] == '0')
                {
                    Arraystring[i] = 0;
                }
                else
                {
                    Arraystring[i] = 1;
                }
            }
            
            BubbleSort(Arraystring);

            Console.WriteLine("Your String\n" + addstring);
            Console.WriteLine();
            Console.WriteLine("Revised String\n");
            PrintArray(Arraystring);

            Console.ReadKey();

        }

        static void PrintArray (int[] temp) //can be replaced with data type of original array
        {
            for (int index = 0; index < temp.Length; index +=1)
            {
                Console.Write(temp[index] + "");
            }
        }
         static void Swap (int[] Array, int pos1, int pos2)
        {
           int temp = Array[pos1];
           Array[pos1] = Array[pos2];
           Array[pos2] = temp;
        }

        static void BubbleSort (int[] Array)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i =1; i < Array.Length; i++)
                {
                    if (Array[i] < Array[i - 1])
                    {
                        Swap(Array,i,i-1);
                        sorted = false;
                    }
                }
            }

        }
    }

    
}
