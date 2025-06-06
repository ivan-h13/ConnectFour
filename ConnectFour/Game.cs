using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Board
    {
        // 7 columns and 6 rows
        private static int row = 7; //static data member
        private static int column = 6; //static data member

        public string[,] gameGrid = new string[row, column];
        public string positionSymbol { get; set; }
        
        public Board()
        {
            //default psotion symbol
            positionSymbol = "#";

            //set default board to be empty spaces represented by "#"
            for (int i = 0; i < gameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < gameGrid.GetLength(1); j++)
                {
                    gameGrid[i, j] = positionSymbol;
                }
            }
        }
        // https://www.geeksforgeeks.org/c-sharp-total-number-of-elements-present-in-an-array/

        public void DisplayGameBoard()
        {
            for(int i = 0; i < gameGrid.GetLength(0); i++)
            {
                //start each row of string with "| "
                Console.Write("| ");

                //populate grid
                for (int j = 0; j < gameGrid.GetLength(1); j++)
                {
                    Console.Write("{0} ", gameGrid[i, j]);
                }

                //end each row with "|"
                Console.WriteLine("|");
            }
        }
    }
    internal class Game
    {
        static void Main(string[] args)
        {
            Board testBoard = new Board();

            testBoard.DisplayGameBoard();
            testBoard.gameGrid[3, 3] = "X";

            Console.WriteLine();
            testBoard.DisplayGameBoard();

        }
    }
}
/*
 * To do list
 * 
 * Make abstract template for players and potentially a AI player
 * Make player class
 * 
 * 
 */ 