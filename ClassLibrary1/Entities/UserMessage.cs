using System;

namespace ClassLibrary1.Entities
{
    [Serializable]
    public class UserMessage
    {
        public string message;
        public string UserFrom;
        public  DateTime Date= DateTime.Now;
    }
}