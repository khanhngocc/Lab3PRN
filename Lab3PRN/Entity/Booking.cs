using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3PRN.Entity
{
    class Booking
    {
        private String username;
        private int flight_id;
        private String flight_name;
        private String airplane_name;
        private DateTime dateTime;

        public string Username { get => username; set => username = value; }
        public int Flight_id { get => flight_id; set => flight_id = value; }

        public string Flight_name { get => flight_name; set => flight_name = value; }
        public string Airplane_name { get => airplane_name; set => airplane_name = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
      
    }
}
