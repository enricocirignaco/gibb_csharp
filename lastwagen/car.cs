using System;

namespace auto
{
    class car
    {
        private string _brand;              // Marke
        private string _model;              // Modell  
        private string _number;             // Nummer
        private double _tankCapacity;       // Tankkapazität [l]   
        private double _tankFillingLevel;   // Tankfüllstand [l]    
        private double _consumption;        // Verbrauch [l / 100 km]     
        private double _totalDistance;      // Tachostand [km]  
        private double _range;              // Reichweite mit dem aktuellen Tankfüllstand [km]

        public car(string brand, string model, string number, double tankCapacity, double consumption)
        {
            _brand = brand;
            _model = model;
            _number = number;
            _tankCapacity = tankCapacity;
            _consumption = consumption;
        }

        // Bestimmte Strecke fahren
        public void Drive(double distance)
        {
            if(distance <= _range)
            {
                _totalDistance = _totalDistance + distance;
                _tankFillingLevel = _tankFillingLevel - (distance*(_consumption/100));
                _range = _tankFillingLevel / (_consumption/100);
            }
            else
            {
                _totalDistance = _totalDistance + _range;
                _tankFillingLevel = 0;
                _range = 0;
            }
        } 

        // Bestimmte Benzinmenge tanken
        public void TankUp(double fuel)
        {
            if(fuel+_tankFillingLevel <= _tankCapacity)
            {
                _tankFillingLevel = _tankCapacity;
            }
            else
            {
                _tankFillingLevel = _tankFillingLevel + fuel;
            }
            _range = _tankFillingLevel / (_consumption/100);
        }

        // Informationen als Zeichenkette abrufen
        public string WrongToString()
        {
            return
                _brand + ", " +
                _model + ", " +
                _number + ", " +
                Math.Round(_tankCapacity, 2).ToString() + ", " +
                Math.Round(_tankFillingLevel, 2).ToString() + ", " +
                Math.Round(_consumption, 2).ToString() + ", " +
                Math.Round(_totalDistance, 2).ToString() + ", " +
                Math.Round(_range, 2).ToString();
        }
    }
}
