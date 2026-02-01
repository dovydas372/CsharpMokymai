using System;
using System.Collections.Generic;
using System.Text;

namespace Objektai__list_advance_7.ND._13_Konversija_į_žodyną
{
    internal class User
    {
        public int ID { get; set; }
        public string Username { get; set; }

        public User (int iD, string username )
        {
            ID = iD;
            Username = username;
        }

        public override string ToString()
        {
            return $"ID: {ID} username: {Username}";
        }
       

    }
}
