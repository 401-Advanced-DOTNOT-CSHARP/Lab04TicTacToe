using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04TicTacToe.Classes
{
	public class Board
	{
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

		public void DisplayBoard()
		{            
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
				for (int j= 0; j< GameBoard.GetLength(1); j++)
                {
					if((j + 1) % 3 == 0)
                        Console.Write($"|{GameBoard[i,j]}|\n");
					else
                        Console.Write($"|{GameBoard[i,j]}|");
                }
            }   
		}
	}
}
