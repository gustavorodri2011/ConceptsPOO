using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(new Date(2024, 2, 29));
                Console.WriteLine(new Date(1974, 10, 05));
                Console.WriteLine(new Date(2005, 11, 30));
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
        }
    }
}
