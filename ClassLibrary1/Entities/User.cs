using System;
using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    [Serializable]
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string pswd { get; set; }
        public bool isOnline { get; set; }
        public List<User> BlackList;
        public override string ToString()
        {
            return name;
        }
    }
}