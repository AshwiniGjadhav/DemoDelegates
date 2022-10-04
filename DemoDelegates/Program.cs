using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoDelegates
{
    public delegate string MyDelegate(string n1);

    public class ULcase
    {
        public string Uppers(string a)
        {
            return a.ToUpper();
        }

        public string Lowers(string a)
        {
            return a.ToLower();
        }
    }
    internal class Program
    {
      //  Write a class with method to accept a name from parameter & return name in uppercase , add another method to accept a name from parameter & return name in lowercase

     //   Create a delegate to invoke these two methods

        static void Main(string[] args)
        {
            ULcase ul = new ULcase();

            MyDelegate myDelegate=new MyDelegate(ul.Uppers);
            myDelegate += new MyDelegate(ul.Lowers);

 Delegate[] list  =   myDelegate.GetInvocationList();

            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke("Ashwini"));
            }
        }
    }
}
