using System;
using System.IO;

namespace weather_data
{
    class Program
    {
    public val pressure = new val();

        static void Main(string[] args)
        {
            val temperature = new val();
            val humidity = new val();
            val rain = new val();

            string path = "/Users/enrico/Documents/gibb_csharp/weather_data/Wetterdaten2011.csv";
            var database_file = new StreamReader(path);

            var lineCount = File.ReadAllLines(@"/Users/enrico/Documents/gibb_csharp/weather_data/Wetterdaten2011.csv").Length;
            Console.WriteLine("Hello World!");
            Console.WriteLine(x);
            string[] y = x.Split(';');
            Console.WriteLine(y[0]);
            Double val = Double.Parse(y[1]);
            Console.WriteLine(lineCount);



            
            for(var i=0; i<lineCount; i++)
            {
                string line = database_file.ReadLine();
                string[] array = line.Split(';');
                pressure.new_val    = Double.Parse(array[0]);
                temperature.new_val = Double.Parse(array[1]);
                humidity.new_val    = Double.Parse(array[2]);
                rain.new_val        = Double.Parse(array[3]);

                database.updateAll();
            }
        }
        public class val
        {
            public double new_val;
            public double max;
            public double min;
            public double avg;
        }
        public class database
        {
            static public void updateAll()
            {
                update_min()
            }
            static private void update_min(object val)
            {

            }

            public void update_max(double new_val)
            {

            }

            public void update_avg(double new_val)
            {

            }
        }
    }
}
