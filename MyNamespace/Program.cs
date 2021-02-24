using MyNamespace.Infrastructure;
using MyNamespace.Interfaces;
using MyNamespace.Structure;
using System;


namespace MyNamespace
{
    class Program
    {

        public string MyProp { get; set; }


        static void Main(string[] args)
        {

             SendMessageBase ob = new SendMessageBase(new SendMail(), "Message by SendMail");


            Console.WriteLine(ob.Text);



            Console.ReadLine();

        }
    }
}
