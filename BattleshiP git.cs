using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace spil
{
    public class BoardSlidesMenu
    {
        string mellem = "";
        BoardSlides boardSlides { get; set; }
        public void Show()
        {


            boardSlides = new BoardSlides();
            boardSlides.SingleUse();
            Console.Clear();

            //var startTimeSpan = TimeSpan.Zero;
            //var periodTimeSpan = TimeSpan.FromSeconds(1);

            //var timer = new System.Threading.Timer((e) =>
            //{

            //}, null, startTimeSpan, periodTimeSpan);




            bool running = true;
            string choice = "";
            do
            {
                Showmenu1();
                choice = GetUserChoice();
                switch (choice)
                {
                    case "1": DoActionFor1(); break;
                    case "2": DoActionFor2(); break;
                    case "3": DoActionFor3(); break;
                    //case "q": MoveShip(); break;
                    //case "4": DoActionFor4(); break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);
        }

        public void Showmenu1()
        {

            Console.Clear();
            if (boardSlides != null)
            {
                Console.WriteLine(boardSlides.BoardSlideMap());

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t BatteShip!!!!!!!!");
            Console.WriteLine();
            Console.WriteLine("\t 1. Opret nyt spil");
            Console.WriteLine("\t 2. placer skib");
            Console.WriteLine("\t 3. Flyt en brik");
            Console.WriteLine();
            Console.WriteLine("0. exit");
            //bool tid = true;


 //           Console.WriteLine("\n" +
 //mellem + "                                     # #  ( ) \n" +
 //mellem + "                                  ___#_#___|__\n" +
 //mellem + "                              _  |____________|  _\n" +
 //mellem + "                      _ =====| | |            | | |====_\n" +
 //mellem + "                =====| |.---------------------------. | |====\n" +
 //mellem + "   \\--------------------'   .  .  .  .  .  .  .  .   '-------------->\n" +
 //mellem + "    \\                                                             /\n" +
 //mellem + "     \\___________________________________________________________/\n" +
 //mellem + " wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww\n" +
 //mellem + "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww\n" +
 //mellem + "  wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww\n");

           // Console.ReadLine();
            //while (tid == true)
            //{
            //    Thread.Sleep(1 * 2 * 1);
            //    mellem += " ";

            //}
            //if (boardSlides != null)
            //{
            //    Console.WriteLine(boardSlides.BoardSlideMap());

            //}


        }
        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Vælg bare bro\n");
            return Console.ReadLine();
        }
        public void ShowMenuSelectionErroe()
        {
            Console.WriteLine("Nej det kan du ikke forhelvede.");
            Console.ReadLine();
        }
        public void DoActionFor1()
        {
            boardSlides = new BoardSlides();
            boardSlides.SingleUse();
        }
        public void DoActionFor2()
        {
            
            String[] SkibNavne = { "Hangarskib", "Slagskib", "Destroyer", "Ubåd", "Patruljebåd" };

            Console.WriteLine(
                 
                "\n 1. Hangarskib   - " + boardSlides.Hangarskib +
                "\n 2. Slagskib     - " + boardSlides.slagskib +
                "\n 3. Destroyer    - " + boardSlides.Destroyer +
                "\n 4. Ubåd         - " +  boardSlides.ubåd +
                "\n 5. PatruljeBåd  - " + boardSlides.patruljebåd);
          
            int type = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine
                    (@"
                    1. Down
                    2. Up
                    3. Left
                    4. Right"
                    );
            int direction = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast koordinat for "+ SkibNavne[type-1]);
            string inputs = Console.ReadLine();
            boardSlides.placeShip(inputs, type, direction);
            
        } 
        public void DoActionFor3()
        {

        }
        //private static System.Timers.Timer aTimer;
        //public void  MoveShip(){
        //    //while (true)
        //    //{
        //    //    mellem += " ";
        //    //}
        //mellem += " ";
        //for (int i = 0; i < 100; i++)
        //    mellem += " ";
        //    aTimer = new System.Timers.Timer(100);

        //    // Hook up the Elapsed event for the 

        //timer.
        //    aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

        //    // Set the Interval to 2 seconds (2000 milliseconds).
        //    aTimer.Interval = 100;
        //    aTimer.Enabled = true;


        //}

        //private void OnTimedEvent(object sender, ElapsedEventArgs e)
        //{
        //    mellem += " ";
        //}

        public void ValidateWinner()
        {

        }
    } 
}
