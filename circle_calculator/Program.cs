using System;

namespace circle_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new calculator object
            calculator my_calculator = new calculator();

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
                        Console.Clear();
                        Console.WriteLine("Kreisumfang\n___________\n");
                        Console.Write("Radius=");
                        UInt16 radius = Convert.ToUInt16(Console.Read());
                        Console.WriteLine(my_calculator.Circumference(radius));
                        System.Environment.Exit(1);
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

    public class calculator
    {
        /*
        * method to calculate circumference.
        */
        public double Circumference(UInt16 radius)
        {
            //formula
            double circumference = Math.Round((2 * radius * Math.PI), 2);
            return circumference;
        }

        /*
        * method to calculate circle area.
        */
        public double Circle_area(UInt16 radius)
        {
            //formula
            double circle_area = Math.Round((Math.Pow(radius, 2) * Math.PI), 2);
            return circle_area;
        }

        /*
        * method to calculate circular arc
        */
        public double Circle_arc(UInt16 radius, UInt16 angle)
        {
            //formula
            double circle_arc = Math.Round(((radius * Math.PI * angle)/180), 2);
            return circle_arc;
        }

        /*
        * method to calculate circular segment
        */
        public double Circle_segment(UInt16 radius, UInt16 angle)
        {
            //formula
            double circle_segment = Math.Round(((Math.Pow(radius, 2) * Math.PI * angle)/360), 2);
            return circle_segment;
        } 
    }
    
}
