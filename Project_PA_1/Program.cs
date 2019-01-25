using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_PA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader infile = new StreamReader("C:\\Users\\CCA011\\source\\repos\\Basketball Awards\\Program.cs");
            char[] split_string = {' ', '\t' };

            Console.WriteLine("This is your comments\n\n");


            while (!infile.EndOfStream)
            {
                string Record = infile.ReadLine();

                if (Record.Contains("//") || Record.Contains("/*") || Record.Contains("*/"))
                {
                    Console.WriteLine(Record);
                    Console.WriteLine();
                }
                else
                {

                }
            }
            Console.ReadKey();

        }


    }
}
