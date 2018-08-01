 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael2018Solution
{
    public class Triangle
    {
        public int triHeight;  //variable height of triangle
        public int triBase;    //variable base of triangle
        public int areaAnswer;
        
        //this is my first method 
        public void TriangleArea()
        {
            areaAnswer = triHeight*triBase; 
            Console.WriteLine("The area of this triangle is {0}", areaAnswer);

        }

    }
}
