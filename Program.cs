using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname=" ", lastname;
            string[] arrayG = { "great", "good", "alright", "horrible" };
            string quality = arrayG[new Random().Next(0,arrayG.Length)];

            while (firstname != "end")
            { 

                Console.WriteLine("Please enter your first name: ");
                firstname = Console.ReadLine();
                Console.WriteLine("Please enter your last name: ");
                lastname = Console.ReadLine();
                Console.WriteLine("{0} {1}, you are" + " " + quality +" " + "!", firstname, lastname);
                Console.ReadLine();
            }
        }
    }
}
