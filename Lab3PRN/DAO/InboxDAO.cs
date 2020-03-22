using Lab3PRN.Entity;
using Lab3PRN.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Lab3PRN.DAO
{
    class InboxDAO
    {
        DBContext dBContext = new DBContext();


        public void deleteInbox(int id)
        {
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Delete from Inbox where id = @val1";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", id);
            command.ExecuteNonQuery();
            cnn.Close();

        }

        public List<Inbox> GetAllInbox()
        {
            List<Inbox> lists = new List<Inbox>();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Inbox.*,Account.username from Inbox,Account"
                           +" where"
                           +" Inbox.account_id = Account.id"
                      ;
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Inbox temp = new Inbox();
                temp.Id = reader.GetInt32(0);
                temp.Message = reader.GetString(1);
                temp.DateTime = reader.GetDateTime(2);
                temp.Account_id = reader.GetInt32(3);
                temp.Username = reader.GetString(4);
                lists.Add(temp);
            }

            cnn.Close();

            return lists;
        }

    }
}
