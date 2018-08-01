using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Michael2018Solution
{
    public class Calculator

    {
        public int FirstNumber;
        public int SecondNumber;
        public int CalAnswer;

        //This will be the substraction method

        public void CalSubstraction()

        {

            CalAnswer = FirstNumber - SecondNumber;
            Console.WriteLine("Substracting the secondNumber from the firstNumber will give {0}", CalAnswer);

        }



        public void CalAddition()

        
        {
            Console.WriteLine();
            CalAnswer = FirstNumber + SecondNumber;
            Console.WriteLine("Adding the FirstNumber to SecondNumber will give {0}",CalAnswer);



        }

        public void CalDivision()
        {
            Console.WriteLine();
            CalAnswer = FirstNumber/SecondNumber;
            Console.WriteLine("Divide the FirstNumber by the SecondNumber will give {0}", CalAnswer);
        }

        public void CalMultiplication(int parameterOne, int parameterTwo)
        {
            Console.WriteLine();
            FirstNumber = parameterOne;
            SecondNumber = parameterTwo;
            CalAnswer = FirstNumber*SecondNumber;
            Console.WriteLine("Multiply FirstNumber by the SecondNumber will give {0}",CalAnswer );

        }

            

    }

}

