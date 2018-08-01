using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using Michael2018Solution.Child;
using Michael2018Solution.Parent;

namespace Michael2018Solution
{
    public class Program
    {
        static void Main(string[] args) //this is the main method
        {
            //Triangle triangleIsoceles = new Triangle();
            //triangleIsoceles.triBase = 10;
            //triangleIsoceles.triHeight = 10;
            //triangleIsoceles.TriangleArea();

            //Calculator substract = new Calculator();
            //substract.FirstNumber = 75;
            //substract.SecondNumber = 25;
            //substract.CalSubstraction();



            //Calculator addition = new Calculator();
            //addition.FirstNumber = 75;
            //addition.SecondNumber = 25;
            //addition.CalAddition();

            //Calculator division = new Calculator();
            //division.FirstNumber = 75;
            //division.SecondNumber = 25;
            //division.CalDivision();

            //Calculator Multiply = new Calculator();
            //Multiply.CalMultiplication(75, 25);

            //Triangle triangleAcc = new Triangle();
            //triangleAcc.TriangleArea();

            //Triangle triangleGP = new Triangle();
            //triangleGP.triHeight = 21;
            //Console.WriteLine("tolu is " + triangleGP.triHeight + "meters tall");


            Folake folake = new Folake();
            folake.PickinName();
            folake.PickinAge();
            folake.childAge = 25;
            folake.PickinAge();
            folake.CallDaddyAge();
            folake.CallDaddyName();
            
            
           

           

            Console.ReadKey();
        } 
    }
}
 