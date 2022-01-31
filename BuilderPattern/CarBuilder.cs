using System;
using System.Collections.Generic;
using System.Text;
using static BuilderPattern.Setters;

namespace BuilderPattern
{
    public class CarBuilder : IBuilder
    {
        private Car car { get; set; }
        public void reset()
        {
            this.car = new Car();
        }

        public void setEngine(string _engineModel)
        {
            this.car._engine = new Engine()
            {
                _capacity = _engineModel,
            };
        }

        public void setGPS(bool _setGPS, string _modelGPS)
        {
            if(_setGPS)
            {
                this.car._gps = new GPS()
                {
                    _model = _modelGPS,
                };                
            } 
        }

        public void setSeats(int _seats, string _seatsMaterial)
        {
            this.car._seats = new Seats()
            {
                _numerSeats = _seats,
                _material = _seatsMaterial,
            };
        }

        public void setTripComputer(bool _setTripComputer, string _nameTripComputer)
        {
            if(_setTripComputer)
            {
                this.car._tripComputer = new TripComputer()
                {
                    _model = _nameTripComputer,
                };
                
            }
        }

        public Car getResult()
        {
            return this.car;
        }
    }
}
