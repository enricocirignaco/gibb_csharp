using System;

namespace lastwagen
{
    class truck : car
    {
         private int _cargoWeight; // Aktuelles Ladegewicht [kg]
         private int _maxCargoWeight; // Maximales Ladegewicht [kg]
        public truck(string brand, string model, string number, double tankCapacity, double consumption, int maxCargoWeight) : base(brand, model, number, tankCapacity, consumption)
        {
            _brand = brand;
            _model = model;
            _number = number;
            _tankCapacity = tankCapacity;
            _consumption = consumption;
            _maxCargoWeight = maxCargoWeight;
        }

        // Ruft den Verbrauch abhängig vom Ladegewicht ab
        public override double GetComsumption()
        {
            return _consumption + (_cargoWeight * 0.002);
        }
        // Fracht mit bestimmten Gewicht laden
        public void Charge(int cargoWeight)
        {
            if(cargoWeight + _cargoWeight > _maxCargoWeight)
            {
                _cargoWeight = _maxCargoWeight;
            }
            else
            {
                _cargoWeight = _cargoWeight + cargoWeight;
            }
        }
        public override string WrongToString()
        {
            return
                base.WrongToString() + ", " +
                _cargoWeight + ", " +
                _maxCargoWeight;
        }
    }
}
