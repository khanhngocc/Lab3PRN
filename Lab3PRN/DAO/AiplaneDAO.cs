using Lab3PRN.Entity;
using Lab3PRN.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Lab3PRN.DAO
{
    class AiplaneDAO
    {
        DBContext dBContext = new DBContext();

        public void insertAirPlane(Airplane airplane)
        {
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Insert into Airplane values(@val1,@val2)";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", airplane.Id);
            command.Parameters.AddWithValue("@val2",airplane.Name);
            command.ExecuteNonQuery();
            cnn.Close();

        }

        public void deleteAirPlane(int id)
        {
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Delete from Airplane where id = @val1";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", id);
            command.ExecuteNonQuery();
            cnn.Close();

        }


     
        public List<Airplane> GetAllAriplane()
        {
            List<Airplane> lists = new List<Airplane>();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select * from Airplane"
                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Airplane temp = new Airplane();
                temp.Id = reader.GetInt32(0);
                temp.Name = reader.GetString(1);
                lists.Add(temp);
            }

            cnn.Close();

            return lists;
        }
    }
}
