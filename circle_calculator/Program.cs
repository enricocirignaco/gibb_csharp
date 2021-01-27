using System;

namespace circle_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kreisberechnungen\n_________________\n");
            Console.WriteLine("Wählen Sie eine der folgende Aktionen:\n");
            Console.WriteLine("[1] Kreisumfang berechnen");
            Console.WriteLine("[2] Kreisfläche berechnen");
            Console.WriteLine("[3] Kreisbogen berechnen");
            Console.WriteLine("[4] Kreissegment berechnen");
            Console.WriteLine("[5] Programm Beenden\n");
            while(true)
            {
                switch(Console.ReadLine())
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Console.WriteLine("Programm Beendet");
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Fehler: option nicht erlaubt.\nVersuchen Sie neu");
                        break;
                }
            }

        }
    }
    /*
    class calculator
    {
        /*
        * method to calculate circumference.
        /
        static UInt16 Circumference(UInt16 radius)
        {
            UInt16 circumference = 2 * radius * Math.PI;
            return circumference;
        }

        /*
        * method to calculate circle area.
        /
        static UInt16 Circle_area(UInt16 radius)
        {
            UInt16 circle_area = Math.Pow(radius, 2) * Math.PI;
            return circle_area;
        }

        /*
        * method to calculate circular arc
        /
        static UInt16 Circle_arc(UInt16 radius, UInt16 angle)
        {
            UInt16 circle_arc = (radius * Math.PI * angle)/180;
            return circle_arc;
        }

        /*
        * method to calculate circular segment
        /
        static UInt16 Circle_segment(UInt16 radius, UInt16 angle)
        {
            UInt16 circle_segment = (Math.Pow(radius, 2) * Math.PI * angle)/360;
            return circle_segment;
        }
        
    }
    */
}
