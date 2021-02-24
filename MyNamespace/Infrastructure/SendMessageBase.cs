using MyNamespace.Interfaces;
using MyNamespace.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNamespace.Infrastructure
{

    class SendMessageBase 
    {
        private  ISendMessage _ISendMessage { get; set; }

        private readonly string _text;

        private  ISendMessage _text2;



        public SendMessageBase(ISendMessage sendMessage,string mesaj)
        {
            _ISendMessage = sendMessage;

            _text =  _ISendMessage.SendNotification(mesaj);


        }




        public string Text
        {
            get { return _text; }
            set { }
        }



    }
}
