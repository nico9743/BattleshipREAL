using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class BoardSlides
    {
        public char[,] GameBoard { get; set; }
        public char[,] GameBoard2 { get; set; }
        public string l = "";
        public string k = "";
        public void SingleUse()        {
            GameBoard = new char[10, 10];
            GameBoard2 = new char[10, 10];
            for (int i = 0; i < 10; 
                i++)
            {
                for (int j = 0; j < 10; j++)

                {
                    GameBoard[i, j] = ' ';
                    GameBoard2[i, j] = ' ';
                }
                
            }
        }
        public string BoardSlideMap()
        {            string result = "  | 1 | 2 | 3 | 4 | 5| 6 | 7 | 8 | 9 | 10 |\n\n";

            Console.ForegroundColor = ConsoleColor.Green;
            
            for (int i = 0; i < 10; i++)
            {
                if (i < 9)
                {
                    result += (i + 1) + " | ";
                }

                else
                {
                    result += (i + 1) + "| ";
                }
                    
                    for (int j = 0; j < 10; j++)
                {
                    result += GameBoard[i, j] +" | ";
                    }
                    result += "\n" + "-------------------------------------------";

                    result += "\n";
                

                

            }
            result = result + l;
            

            return result ;
            //BoardSlidesMenu boardSlidesMenu = new BoardSlidesMenu(); 
            
            
        }
        int shipPlayer = 0;
        public int Destroyer = 2;
        public int Hangarskib = 1;
        public int patruljebåd = 3;
        public int slagskib = 2;
        public int ubåd = 1;
        public void placeShip(string input, int Skib, int direction)
        {
            int[] skibsLængde = { 5, 4, 3, 3, 2 };
            char[] skibForbogstav = { 'H', 'S', 'D', 'U', 'P' }; 
            int valgteSkib = skibsLængde[Skib - 1];
            //Console.ForegroundColor = ConsoleColor.Green;            
            string[] placeP = input.Split(',');
            int x = Convert.ToInt32(placeP[0]) - 1;
            int y = Convert.ToInt32(placeP[1]) - 1;
            l = "" + x + "" + y;
            
            
            if (shipPlayer == 0)
            {
                
                shipPlayer = 1;
            }
            else
            {
                shipPlayer = 0;
            }

            int isPlaceAvailable = 0;
            // gemme værdier I gameboardet!


            for (int j = 0; j < valgteSkib; j++)
            {
                if (direction == 1 && (y + j) >= 0 && (y + j) <= 9 && x >= 0 && x <= 9)
                {
                    if (GameBoard[y + j, x] == ' ')
                        isPlaceAvailable++;
                }
                if (direction == 2 && (y - j) >= 0 && (y - j) <= 9 && x >= 0 && x <= 9)
                {
                    if (GameBoard[y - j, x] == ' ')
                        isPlaceAvailable++;
                }
                if (direction == 3 && (x - j) >= 0 && (x - j) <= 9 && y>= 0 && y<= 9) 
                {
                    if (GameBoard[y, x - j] == ' ')
                        isPlaceAvailable++;
                }
                if (direction == 4 && (x + j) >= 0 && (x + j) <= 9 && y >= 0 && y <= 9)
                {
                    if (GameBoard[y, x + j] == ' ')
                        isPlaceAvailable++;
                }
            }


            if (isPlaceAvailable == valgteSkib)
            {
                if (Skib == 1)
                    Hangarskib--;
                if (Skib == 2)
                    slagskib--;
                if (Skib == 3)
                    Destroyer--;
                if (Skib == 4)
                    ubåd--;
                if (Skib == 5)
                    patruljebåd--;


                for (int i = 0; i < valgteSkib; i++)
                {
                    if (direction == 4)
                        GameBoard[y, x + i] = skibForbogstav[Skib - 1];
                    if (direction == 2)
                        GameBoard[y - i, x] = skibForbogstav[Skib - 1];
                    if (direction == 3)
                        GameBoard[y, x - i] = skibForbogstav[Skib - 1];
                    if (direction == 1)
                        GameBoard[y + i, x] = skibForbogstav[Skib - 1];
                }
            }
            else
            {
                BoardSlidesMenu menu = new BoardSlidesMenu();
                menu.ShowMenuSelectionErroe();
            }
            if (Hangarskib ==0 && slagskib == 0 && Destroyer == 0 && ubåd == 0 && patruljebåd == 0)
            {

            }






        }
    }
}
