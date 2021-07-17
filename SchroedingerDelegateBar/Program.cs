using System;

namespace SchroedingerDelegateBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar bar = new Bar();
            Person besucher1 = new Person() { Name = "Schrödinger" };
            Person besucher2 = new Person() { Name = "Bernhard" };
            besucher1.Eintreten(bar);
            besucher2.Eintreten(bar);
            bar.RundeAusgeben();
            Console.ReadKey();
        }
    }
}
