//using c = System.Console; - alias
//using System;
//
//namespace HelloCsharp //directory
//{
//    class Program
//    {
//        static void Main(string[] args) //Pascal Casing - first letter of every word must be capitalized
//        {
//            Console.WriteLine("Hello World!");
//            HelloCsharp.Program.Main("");
 //       }
//    }
//}
using System;

namespace HelloCsharp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Firstname: ");
            var firstName = Console.ReadLine(); //Lazy, datatype given based on content of Readline
            Console.Write("Enter Lastname: ");
            string lastName = Console.ReadLine(); //Eager, datatype is explicit pior to content of readline

            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("{0} {1}", firstName, lastName);
            Console.WriteLine($"{firstName} {lastName}");

            Console.ReadLine();
        }
    }
}