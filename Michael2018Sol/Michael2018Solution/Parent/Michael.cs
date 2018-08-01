using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael2018Solution.Parent
{
    public class Michael
    {
        protected string parentName = "Michael";
        protected int parentAge = 45;

        protected void PickinName()
        {
            Console.WriteLine("My Dad's name is {0}", parentName);
        }

        protected void PickinAge()
        {
            Console.WriteLine("He is {0} years old", parentAge);
        }
    }
}
