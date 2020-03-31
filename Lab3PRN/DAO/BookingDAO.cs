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
            String query = "Select Account.username,Flight.id,Flight.name,Airplane.name,Booking.date_time from Booking,Account,Flight,Airplane,Owner_Flight"
                        +" where"
                        +" Booking.account_id = Account.id"
                        +" and"
                        +" Booking.flight_id = Flight.id"
                        +" and"
                        +" Airplane.id = Owner_Flight.airplane_id"
                        +" and"
                        +" Flight.id = Owner_Flight.flight_id"
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

        public List<Booking> FilterBookingByUsername(String username)
        {
            String parten = "%" + username + "%";
            List<Booking> lists = new List<Booking>();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Account.username,Flight.id,Flight.name,Airplane.name,Booking.date_time from Booking,Account,Flight,Airplane,Owner_Flight"
                        + " where"
                        + " Booking.account_id = Account.id"
                        + " and"
                        + " Booking.flight_id = Flight.id"
                        + " and"
                        + " Airplane.id = Owner_Flight.airplane_id"
                        + " and"
                        + " Flight.id = Owner_Flight.flight_id"
                        + " and Account.username like @val1"
                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", parten);
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

        public double GetTotalMoney()
        {
            double num = 0;
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select price from Booking,Flight"
                           +" where Flight.id = Booking.flight_id"

                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                num += reader.GetDouble(0);
            }

            cnn.Close();

            return num;
        }


        public int NumberTotalTicket()
        {
            int num = 0;
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Count(*) from Flight"
                        
                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
           
            if(reader.Read())
            {
                num = reader.GetInt32(0);
            }

            cnn.Close();

            return num;
        }


        public int NumberFreeTicket()
        {
            int num = 0;
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Count(*) from Flight"
                           +" where"
                           +" Flight.id not in (Select Booking.flight_id from Booking)"

                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                num = reader.GetInt32(0);
            }

            cnn.Close();

            return num;
        }

        public int NumberBookedTicket()
        {
            int num = 0;
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Count(*) from Flight"
                           + " where"
                           + " Flight.id in (Select Booking.flight_id from Booking)"

                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                num = reader.GetInt32(0);
            }

            cnn.Close();

            return num;
        }
    }
}
