using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Gussing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Number Gussing Game");
            Random r = new Random();
            int rno = r.Next(1, 100);
            Console.WriteLine(rno);

            bool win=false;
            do
            {
                Console.Write("Enter ur number:");
                int number = int.Parse(Console.ReadLine());

                if(rno>number)
                {
                    
                    Console.WriteLine("To low think high" );

                }
                else if(rno<number)
                {
                 
                    Console.WriteLine("too high think low");
                }
                else if(rno==number)
                {
                    Console.WriteLine("Win");
                    win=true;
                }

            } while (win == false);
          
           
        }
    }
}
