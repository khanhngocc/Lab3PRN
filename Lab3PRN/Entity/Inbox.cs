using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3PRN.Entity
{
    class Inbox
    {
        private int id;
        private String message;
        private DateTime dateTime;
        private int account_id;
        private String username;
        public int Id { get => id; set => id = value; }
        public string Message { get => message; set => message = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public int Account_id { get => account_id; set => account_id = value; }
        public string Username { get => username; set => username = value; }
    }
}
