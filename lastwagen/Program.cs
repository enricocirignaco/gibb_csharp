using System;

namespace lastwagen
{
    class Program
    {
        static void Main(string[] args)
        {
            truck scania_scr = new truck("Scania", "SCR", "BE 52625", 850, 25.5, 40000);
            truck mercedes_actros = new truck("Mercedes", "Actros", "BE 263254", 1000, 35.2, 60000);
            scania_scr.TankUp(60000);
            mercedes_actros.TankUp(300000);
            
            scania_scr.Charge(38250);
            mercedes_actros.Charge(55100);

            scania_scr.Drive(190);
            mercedes_actros.Drive(150);
            Console.WriteLine(scania_scr.WrongToString());
            Console.WriteLine(mercedes_actros.WrongToString());
        }
    }
}
