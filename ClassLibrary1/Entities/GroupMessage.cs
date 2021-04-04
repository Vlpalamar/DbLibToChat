using System;
using System.Collections.Generic;

namespace ClassLibrary1.Entities
{
    [Serializable]
    public class GroupMessage
    {
        public string message;
        public User FromeUser;
        public List<User> toGroupe;
        public DateTime Date = DateTime.Now;
    }
}