using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6
{
   
    internal class Program
    { 
        public bool isanagram(string a,string b)
        {
           var str1= a.ToLower().ToArray();
           var str2= b.ToLower().ToArray();
            Array.Sort(str1);
            Array.Sort(str2);

            return new string(str1)==new string (str2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string ");
            string a=Console.ReadLine();
            Console.WriteLine("enter second string");
            string b=Console.ReadLine();
            Program p = new Program();
           if(p.isanagram(a,b)==true)
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }
        }
    }
}
