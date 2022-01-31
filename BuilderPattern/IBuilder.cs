using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void reset();

        void setSeats(int _seats, string _seatsMaterial);

        void setEngine(string _engineModel);

        void setTripComputer(bool _setTripComputer, string _nameTripComputer);
        void setGPS(bool _setGPS, string _modelGPS);
    }
}
