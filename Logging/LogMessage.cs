using System;
using System.Collections.Generic;
using System.Text;

namespace Logging
{
    public class LogMessage
    {
        public LogMessage()
        {
        }

        public LogMessage(string category, string message)
        {
            Date = DateTime.Today;
            Category = category;
            Message = message;
        }

        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Message { get; set; }
    }
}
