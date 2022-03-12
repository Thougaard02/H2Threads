using System;
using System.Collections.Generic;
using System.Text;

namespace Bagagesorteringssystem
{
    public class CentralServer
    {
        public static Queue<Luggage> Luggage = new Queue<Luggage>();
        public enum Destinations
        {
            Copenhagen,
            Texas,
            Egypten
        }
    }
}
