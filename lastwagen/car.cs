using System;

namespace lastwagen
{
    class car
    {
        public string _brand{get; protected set;}               // Marke
        public string _model{get; protected set;}               // Modell  
        public string _number{get; protected set;}              // Nummer
        public double _tankCapacity{get; protected set;}        // Tankkapazität [l]   
        public double _tankFillingLevel{get; protected set;}    // Tankfüllstand [l]    
        public double _consumption{get; protected set;}         // Verbrauch [l / 100 km]     
        public double _totalDistance{get; protected set;}       // Tachostand [km]  
        public double _range{get; protected set;}               // Reichweite mit dem aktuellen Tankfüllstand [km]

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
            if(distance < _range)
            {
                _totalDistance = _totalDistance + distance;
                _tankFillingLevel = _tankFillingLevel - (distance*(GetComsumption()/100));
                _range = _tankFillingLevel / (GetComsumption()/100);
            }
            else
            {
                _totalDistance = _totalDistance + _range;
                _tankFillingLevel = 0;
                _range = 0;
            }
        } 
        // Ruft den Verbrauch abhängig vom Ladegewicht ab
        public virtual double GetComsumption()
        {
            return _consumption;
        }
        // Bestimmte Benzinmenge tanken
        public void TankUp(double fuel)
        {
            if(fuel+_tankFillingLevel > _tankCapacity)
            {
                _tankFillingLevel = _tankCapacity;
            }
            else
            {
                _tankFillingLevel = _tankFillingLevel + fuel;
            }
            _range = _tankFillingLevel / (GetComsumption()/100);
        }

        // Informationen als Zeichenkette abrufen
        public virtual string WrongToString()
        {
            return
                _brand + ", " +
                _model + ", " +
                _number + ", " +
                Math.Round(_tankCapacity, 2).ToString() + ", " +
                Math.Round(_tankFillingLevel, 2).ToString() + ", " +
                Math.Round(GetComsumption(), 2).ToString() + ", " +
                Math.Round(_totalDistance, 2).ToString() + ", " +
                Math.Round(_range, 2).ToString();
        }
    }
}
