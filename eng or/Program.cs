using System;

namespace eng_or
{
    class Program
    {
        static void Main(string[] args)
        {
            string login="admin";
            string password = "pass1234";
            
            string userName, userPassword;

            int tries = 0;

            while (tries!=3)
            {
                Console.WriteLine("enter ur username >>> ");
                userName = Console.ReadLine();
                Console.WriteLine("enter ur password >>> ");
                userPassword = Console.ReadLine();

                if (login != userName || password != userPassword)
                {
                    Console.WriteLine("try again T_T");
                    tries++;
                }
                else
                {
                    Console.WriteLine("Welcome to the club, buddy");
                }

                //if (login == userName && password == userPassword)
                //{
                //    Console.WriteLine("Welcome to the club, buddy");
                //}
                //else
                //{
                //    Console.WriteLine("try again T_T")
                //} 
            }




            }
        }
}
