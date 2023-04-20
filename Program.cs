using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clock.BL;
namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {

            clocktype Obj = new clocktype(12,3,4);
            Obj.elapsed();
            Obj.in_to_sec();
            int elapsed = 0;
            elapsed = Obj.hours + Obj.min + Obj.sec;
            clocktype Ob = new clocktype(Obj);
            int remaning = Ob.remaning();
            clocktype Ob1 = new clocktype();
            int appart_time = Ob1.difference_bt_two_clock(Obj);
            int option = 0;

            do
            {
                 option = MANU();

                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("YOUR ELAPSED TIME IS:{0}", elapsed);
                    Console.ReadLine();
                }
                else if (option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("YOUR REMANING TIME IS :{0}", remaning);
                    Console.ReadLine();
                }
                else if (option == 3)
                {
                    Console.Clear();
                    Console.WriteLine("YOUR APPART TIME IS{0}:", appart_time);
                    Console.ReadLine();

                }
                else if (option == 4)
                {
                    Console.Clear();
                    clocktype Ob2 = new clocktype();

                    Ob2.show_time_in_sec(elapsed, remaning, appart_time);
                    Console.ReadLine();
                }
               
            } while (option != 5);
        }
 
    
     static int MANU()
        {
            int option;
            Console.WriteLine("1.FOR ELAPSED TIME");
            Console.WriteLine("2.FOR REMANING TIME");
            Console.WriteLine("3.FOR APPART  TIME");
            Console.WriteLine("4.FOR  TIME HH,MM,SS IN FORMAT");
            Console.WriteLine("5.FOR  EXIST");

            option = int.Parse(Console.ReadLine());
            return option;
        }
        


    
    }
}

