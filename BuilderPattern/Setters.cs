using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Setters
    {
        public class Engine
        {
            public string _model { get; set; }
            public string _description { get; set; }
            public string _capacity { get; set; }
        }

        public class GPS
        {
            public string _model { get; set; }
            public string _description { get; set; }
            public string _installation { get; set; }
        }

        public class Seats
        {
            public int _numerSeats { get; set; }
            public string _material { get; set; }
            public string _description { get; set; }
        }

        public class TripComputer
        {
            public string _model { get; set; }
            public string _description { get; set; }
            public string _type { get; set; }
        }
    }
}
