using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_PA_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader infile = new StreamReader("C:\\temp\\Frame.txt");
            char[] split_string = {' ', '\t' };
            int star = 0;
            Console.SetCursorPosition(0,1);


            while (!infile.EndOfStream)
            {
                string Record = infile.ReadLine();

                string[] Fields = Record.Split(split_string);

                for (int i = 0; i < Fields.Length; i++)
                {
                    if (Fields.Length > star)
                    {
                        star = Fields.Length;
                    }               
                }

                PrintArray(Fields,star);

                for (int i = 0; i < star; i++)
                {
                    Console.Write("*");
                    if (i == star - 1)
                    {
                        Console.Write("*");
                    }
                }

                Console.SetCursorPosition(0,0);

                for (int i = 0; i < star; i++)
                {
                    Console.Write("*");
                    if (i == star - 1)
                    {
                        Console.Write("*");
                    }
                }

                for (int i = 0; i < Fields.Length; i++)
                {
                    Console.SetCursorPosition(star,i);
                    Console.Write("*");

                    if (i == Fields.Length - 1)
                    {
                        Console.SetCursorPosition(star,i+1);
                        Console.Write("*");
                    }
                }




            }

            Console.ReadKey();
        }

        static void PrintArray (string[] temp, int star) //can be replaced with data type of original array
        {
            int Space = 0;
            for (int index = 0; index < temp.Length; index +=1)
            {
                
                Console.WriteLine("*" + temp[index] + "");


                
            }
        }
    }
}
