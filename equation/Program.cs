using System;

namespace equation_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LEquation le = new LEquation(4, 0);
                Console.WriteLine(le.Root);
                LEquation le2 = LEquation.Parse("3 6");
                Console.WriteLine(le2.Root);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
