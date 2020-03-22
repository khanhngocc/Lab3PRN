using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3PRN.Entity
{
    class Flight
    {
        private int id;
        private String depart_time;
        private String depart_date;
        private String arrival_time;
        private String arrival_date;
        private String depart_country;
        private String arrival_country;
        private String direction;
        private String type;
        private float price;
        private int no_seat;
        private String airplane_name;
        public int Id { get => id; set => id = value; }
        public string Depart_time { get => depart_time; set => depart_time = value; }
        public string Depart_date { get => depart_date; set => depart_date = value; }
        public string Arrival_time { get => arrival_time; set => arrival_time = value; }
        public string Arrival_date { get => arrival_date; set => arrival_date = value; }
        public string Depart_country { get => depart_country; set => depart_country = value; }
        public string Arrival_country { get => arrival_country; set => arrival_country = value; }
        public string Direction { get => direction; set => direction = value; }
        public string Type { get => type; set => type = value; }
        public float Price { get => price; set => price = value; }
        public int No_seat { get => no_seat; set => no_seat = value; }
        public string Airplane_name { get => airplane_name; set => airplane_name = value; }
    }
}
