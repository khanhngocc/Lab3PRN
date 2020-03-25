using Lab3PRN.Entity;
using Lab3PRN.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Lab3PRN.DAO
{
    class FlightDAO
    {
        DBContext dBContext = new DBContext();
        public void insertFlight(Flight flight)
        {
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Insert into Flight values(@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9,@val10,@val11,@val12)";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1",flight.Id);
            command.Parameters.AddWithValue("@val2",flight.Depart_time);
            command.Parameters.AddWithValue("@val3", flight.Depart_date);
            command.Parameters.AddWithValue("@val4", flight.Arrival_time);
            command.Parameters.AddWithValue("@val5", flight.Arrival_date);
            command.Parameters.AddWithValue("@val6", flight.Depart_country);
            command.Parameters.AddWithValue("@val7", flight.Arrival_country);
            command.Parameters.AddWithValue("@val8", flight.Direction);
            command.Parameters.AddWithValue("@val9", flight.Type);
            command.Parameters.AddWithValue("@val10", flight.Price);
            command.Parameters.AddWithValue("@val11", flight.No_seat);
            command.Parameters.AddWithValue("@val12", flight.Name);
            command.ExecuteNonQuery();
            cnn.Close();

        }

        public void insertOwnerFlight(int flight_id,int airplane_id)
        {
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Insert into Owner_Flight values(@val1,@val2)";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", airplane_id);
            command.Parameters.AddWithValue("@val2", flight_id);
            command.ExecuteNonQuery();
            cnn.Close();

        }

        public void deleteFlight(int id)
        {
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Delete from Flight where id = @val1";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", id);
            command.ExecuteNonQuery();
            cnn.Close();

        }

        public void deleteOwnerFlight(int flight_id, int airplane_id)
        {
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Delete from Owner_Flight where airplane_id = @val1 and flight_id = @val2";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", airplane_id);
            command.Parameters.AddWithValue("@val2", flight_id);
            command.ExecuteNonQuery();
            cnn.Close();

        }

        public bool isExistedFlightForDelete(int flight_id, int airplane_id)
        {
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select * from Owner_Flight where airplane_id = @val1 and flight_id = @val2";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", airplane_id);
            command.Parameters.AddWithValue("@val2", flight_id);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                return true;
            cnn.Close();

            return false;
        }

        public List<Flight> GetAllFlight()
        {
            List<Flight> lists = new List<Flight>();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Flight.*,Airplane.name from Flight,Owner_Flight,Airplane" +
                          " where Flight.id = Owner_Flight.flight_id and"
                          + " Airplane.id = Owner_Flight.airplane_id"
                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Flight temp = new Flight();
                temp.Id = reader.GetInt32(0);
                temp.Depart_time = reader.GetString(1);
                temp.Depart_date = reader.GetString(2);
                temp.Arrival_time = reader.GetString(3);
                temp.Arrival_date = reader.GetString(4);
                temp.Depart_country = reader.GetString(5);
                temp.Arrival_country = reader.GetString(6);
                temp.Direction = reader.GetString(7);
                temp.Type = reader.GetString(8);
                temp.Price = (float)reader.GetDouble(9);
                temp.No_seat = reader.GetInt32(10);
                temp.Name = reader.GetString(11);
                temp.Airplane_name = reader.GetString(12);
                lists.Add(temp);
            }

            cnn.Close();

            return lists;
        }

        public List<Flight> GetAllFreeFlight()
        {
            List<Flight> lists = new List<Flight>();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Flight.*,Airplane.name from Flight,Owner_Flight,Airplane" +
                          " where Flight.id = Owner_Flight.flight_id and"
                          + " Airplane.id = Owner_Flight.airplane_id"
                          +" and"
                           + " Flight.id not in (Select Booking.flight_id from Booking)"
                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Flight temp = new Flight();
                temp.Id = reader.GetInt32(0);
                temp.Depart_time = reader.GetString(1);
                temp.Depart_date = reader.GetString(2);
                temp.Arrival_time = reader.GetString(3);
                temp.Arrival_date = reader.GetString(4);
                temp.Depart_country = reader.GetString(5);
                temp.Arrival_country = reader.GetString(6);
                temp.Direction = reader.GetString(7);
                temp.Type = reader.GetString(8);
                temp.Price = (float)reader.GetDouble(9);
                temp.No_seat = reader.GetInt32(10);
                temp.Name = reader.GetString(11);
                temp.Airplane_name = reader.GetString(12);
                lists.Add(temp);
            }

            cnn.Close();

            return lists;
        }

        public List<Flight> GetAllBookedFlight()
        {
            List<Flight> lists = new List<Flight>();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Flight.*,Airplane.name from Flight,Owner_Flight,Airplane" +
                          " where Flight.id = Owner_Flight.flight_id and"
                          + " Airplane.id = Owner_Flight.airplane_id"
                          + " and"
                           + " Flight.id in (Select Booking.flight_id from Booking)"
                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Flight temp = new Flight();
                temp.Id = reader.GetInt32(0);
                temp.Depart_time = reader.GetString(1);
                temp.Depart_date = reader.GetString(2);
                temp.Arrival_time = reader.GetString(3);
                temp.Arrival_date = reader.GetString(4);
                temp.Depart_country = reader.GetString(5);
                temp.Arrival_country = reader.GetString(6);
                temp.Direction = reader.GetString(7);
                temp.Type = reader.GetString(8);
                temp.Price = (float)reader.GetDouble(9);
                temp.No_seat = reader.GetInt32(10);
                temp.Name = reader.GetString(11);
                temp.Airplane_name = reader.GetString(12);
                lists.Add(temp);
            }

            cnn.Close();

            return lists;
        }
    }
}
