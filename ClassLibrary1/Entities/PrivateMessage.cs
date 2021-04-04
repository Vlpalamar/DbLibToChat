using System;

namespace ClassLibrary1.Entities
{
    [Serializable]
    public class PrivateMessage
    { 
        public string message;
        public User UserFrom;
        public User UserTo;
        public DateTime Date = DateTime.Now;
        
    }
}
