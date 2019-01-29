using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject
    /*
     * This is a muti-line comment
     */
{
    class Program   //This is a class
    {
        static int a = 7;
        static void WhileExample()
        {
            var counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Count is {counter}");
                counter = counter + 1;
            }
        }
        static void Print()
        {
            Console.WriteLine($"The value of a is {a}");
        }
        static void Main(string[] args) //This is a method
        {
            WhileExample();
            Print();
            var counter = 0;
            //var a = 7;
            var b = 13;
            var c = a * b;
            Console.WriteLine("Hello, World!"); //This is a statement, Console is a class in namespace
            Console.WriteLine("By Chris");
            Console.WriteLine("Another line.");
            Console.WriteLine($"For a = {a} and b = {b}, A*B = {c}");
            Console.WriteLine($"Value of counter is {counter}");
            Console.WriteLine("Value of counter is " + counter); //dont use it this way, this is old way
        }
    }
}
