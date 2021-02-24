using System;

namespace ConsoleApp4
{
     class Program 

    {

        // internal -> [incaptualtion] eyni namespace altinda olan classlar taniyir



        // static -> adres deyishmirik

        // abstract - > new() olmaz, inheritance, obyekti yaratmaq olmaz

        // public   -> icaze veririk ki, her yerden klassa muraciyyet edilsin


        // sealed   -> inheritance olmaz cunki mohur vurduq


        // partial  -> classlari hisslere boluruk


        // extensions
       

        static void Main(string[] args)
        {

            Program program = new Program();

            program.MyMethod(new Test2(), new A(), "File is A");

                
            Console.ReadLine();
            
        }

        // S 
        /*
          O L I D
          KISS
          DRY
        */


        public void MyMethod(Test2 test, IA ia, string filename)
        {


            test.Include(ia, filename);
        }

    }
}
