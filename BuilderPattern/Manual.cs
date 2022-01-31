using System;
using System.Collections.Generic;
using System.Text;
using static BuilderPattern.Setters;

namespace BuilderPattern
{
    public class Manual
    {
        public Engine _engine { get; set; }
        public GPS _gps { get; set; }
        public Seats _seats { get; set; }
        public TripComputer _tripComputer { get; set; }
    }
}
