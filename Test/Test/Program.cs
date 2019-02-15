using System;

namespace Test
{
    internal static class Program
    {
        private static readonly IService service = new Service();

        private static void Main()
        {
            // Dances.DoubleStepLeft();
            Console.WriteLine(service.GetGreeting("Jan"));

            Console.ReadKey();
        }
    }
}
