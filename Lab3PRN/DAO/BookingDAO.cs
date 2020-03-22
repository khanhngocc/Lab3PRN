using Lab3PRN.Entity;
using Lab3PRN.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Lab3PRN.DAO
{
    class BookingDAO
    {
        DBContext dBContext = new DBContext();

        public List<Booking> GetAllBooking()
        {
            List<Booking> lists = new List<Booking>();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Account.username,Booking.flight_id,Flight.name,Airplane.name,Booking.date_time from Booking,Account,Airplane,Flight,Owner_Flight"
                           + " where Booking.account_id = Account.id"
                           +" and"
                           +" Airplane.id = Booking.airplane_id"
                           +" and"
                           +" Flight.id = Booking.airplane_id"
                           +" and"
                           +" Owner_Flight.airplane_id = Airplane.id"
                           +" and"
                           +" Owner_Flight.flight_id = Flight.id"
                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Booking temp = new Booking();
                temp.Username = reader.GetString(0);
                temp.Flight_id = reader.GetInt32(1);
                temp.Flight_name = reader.GetString(2);
                temp.Airplane_name = reader.GetString(3);
                temp.DateTime = reader.GetDateTime(4);
                lists.Add(temp);
            }

            cnn.Close();

            return lists;
        }
    }
}
