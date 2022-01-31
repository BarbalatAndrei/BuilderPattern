using System;
using System.Collections.Generic;
using System.Text;
using static BuilderPattern.Setters;

namespace BuilderPattern
{
    class ManualBuilder : IBuilder
    {
        private Manual manual { get; set; }
        public void reset()
        {
            this.manual = new Manual();
        }

        public void setEngine(string _engineModel)
        {
            this.manual._engine = new Engine()
            {
                _model = "V8 Turbo",
                _description = "A V8 engine is an eight-cylinder piston engine in which the cylinders share a common crankshaft and are arranged in a V configuration.",
            };
        }

        public void setGPS(bool _setGPS, string _modelGPS)
        {
            if(_setGPS)
            {
                this.manual._gps = new GPS()
                {
                    _model = _modelGPS,
                    _description = "GPS, or the Global Positioning System, is a global navigation satellite system that provides location, velocity and time synchronization.",
                    _installation = "Connect the power: The device should be connected to the power supply. There are two types of device power: battery powered and hardwired to the car battery."
                };
            }
        }

        public void setSeats(int _seats, string _seatsMaterial)
        {
            this.manual._seats = new Seats()
            {
                _material = _seatsMaterial,
                _description = " That is why seats can be individually adjusted. With small adjustments, such as raising the seat or shifting it to the rear, effective modifications can be made that can lead to an adequate seating position.",
            };
        }

        public void setTripComputer(bool _setTripComputer, string _nameTripComputer)
        {
            if(_setTripComputer)
            {
                this.manual._tripComputer = new TripComputer()
                {
                    _model = _nameTripComputer,
                    _type = "smart",
                    _description = "A trip computer is a computer fitted to some cars; most modern trip computers record, calculate, and display the distance travelled, the average speed, the average fuel consumption, and real-time fuel consumption.",
                };
            }
        }

        public Manual getResult()
        {
            return this.manual;
        }
    }
}
