using System;

namespace kr_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            variant_2 tt = new variant_2();            
            Console.WriteLine("Hello World!" + tt.test());   
            x = Console.ReadLine();         
            Console.WriteLine("Hello World!" + tt.test());
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
