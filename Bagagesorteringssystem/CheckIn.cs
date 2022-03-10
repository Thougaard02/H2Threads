using System;
using System.Collections.Generic;
using System.Text;

namespace Bagagesorteringssystem
{
    public class CheckIn
    {
        public int Id { get; set; }
        public bool IsOpen { get; set; }
        public Queue<Luggage> Luggages { get; set; }

        public CheckIn(int id)
        {
            Id = id;
            IsOpen = false;
            Luggages = new Queue<Luggage>();
        }
    }
}
