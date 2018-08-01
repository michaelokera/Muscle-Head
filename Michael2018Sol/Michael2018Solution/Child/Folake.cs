using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Michael2018Solution.Parent;

namespace Michael2018Solution.Child
{
    public class Folake : Michael //this is known as the base class
    {
        public string childName = "Folake";
        public int childAge = 24;
        
        Folake folake = new Folake();
        
        
        public void PickinName()
        {
            Console.WriteLine("My name is {0}", childName);
           
        }

        public void PickinAge()
        {
            Console.WriteLine("I am {0} years old", childAge);
        }

        public void CallDaddyName()
        {
            Console.WriteLine("My surname is {0}", parentName);
        }

        public void CallDaddyAge()
        {
            Console.WriteLine("My Daddy's age is {0}", parentAge);
        }

    }
}
