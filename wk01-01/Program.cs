using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk01_01
{
   public class Program
    {
       public static void Main(string[] args)
        {
            //call the hello world to console method;
            HelloWorldToConsole();
        }
        public static string HelloWorldToConsole()
        {
            /*
             * @description this is my hello world method
             * @return {string} HelloWorldString
             */
            string HelloWorldString = "Hello, World";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;
        }
    }
}
