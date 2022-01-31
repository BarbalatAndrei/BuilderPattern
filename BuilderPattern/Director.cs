using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Director
    {
        public void commandNewCar(IBuilder builder)
        {
            builder.reset();
            builder.setEngine("2.5");
            builder.setGPS(true, "Hitachi");
            builder.setSeats(4, "Alcantara");
            builder.setTripComputer(true, "Pioner");
        }

        public void commandMountainCar(IBuilder builder)
        {
            builder.reset();
            builder.setEngine("5.5");
            builder.setGPS(true, "Pioner");
            builder.setSeats(4, "Alcantara");
            builder.setTripComputer(true, "Pioner");
        }
    }
}
