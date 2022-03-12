using System;
using System.Collections.Generic;
using System.Text;

namespace Bagagesorteringssystem
{
    public class Flight
    {
        public string Name { get; set; }
        public string Destination { get; set; }
        public Queue<Luggage> Luggage { get; set; }

        public Flight(string name, string destination)
        {
            Name = name;
            Destination = destination;
            Luggage = new Queue<Luggage>();
        }
    }
}
