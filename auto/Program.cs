using System;

namespace auto
{
    class Program
    {
        static void Main(string[] args)
        {
            car audi_a6 = new car("Audi", "A6", "BE49025", 60, 5.6);
            car fiat_panda = new car("Fiat", "Panda", "BE 256854", 30, 6.7);
            audi_a6.TankUp(60);
            fiat_panda.TankUp(30);
            audi_a6.Drive(120);
            fiat_panda.Drive(80);

            Console.WriteLine(audi_a6.WrongToString());
            Console.WriteLine(fiat_panda.WrongToString());
        }
    }
}
