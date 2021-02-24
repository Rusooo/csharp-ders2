using MyNamespace.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNamespace.Structure
{
    public class SendMail : ISendMessage
    {
        public string SendNotification(string text)
        {
            return text;
        }
    }
}
