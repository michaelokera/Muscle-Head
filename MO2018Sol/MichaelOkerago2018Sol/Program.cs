using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelOkerago2018Sol
{
    class Program
    {
        //This is a single comment 
        //and this is the main method
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Class of 2018!");

            /*
             * This is a multiline comment
             * The following are data types in C#
             * The building blocks of code
             */ 

            //datatype variableName value
            int age = 25;
            char alphabet = 'm';
            string name = "Santos67500";      //this is an alphanumeric value
            double bankBalance = 350000;
            //DateTime.Today
            bool stateValue = true;

              Console.WriteLine("my age is " + age);
            Console.WriteLine("the first letter of my name is " + alphabet);
            Console.WriteLine("my name is " + name);
            Console.WriteLine(bankBalance);
            Console.WriteLine("I am a man: " + stateValue);
            Console.WriteLine(DateTime.Now);
            
            //THIS IS THE IF STATEMENT

            if (name =="Santos67500")
            {
                Console.WriteLine("This is my name");
            }
             
           

            Console.ReadKey();
        }
    }
}
