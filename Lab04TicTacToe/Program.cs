using Lab04TicTacToe.Classes;
using System;

namespace Lab04TicTacToe
{
    public class Program
    {
        /// <summary>
        /// This is what runs the program
        /// </summary>
        /// <param name="args">string of args</param>
        static void Main(string[] args)
        {
            StartGame();
        }
        /// <summary>
        /// Asks users for name and beings the game and outputs to the console the name of the winner
        /// </summary>
        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is, output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Please enter Player's 1 name: ");
            string player1Name = Console.ReadLine();

            Player playerOne = new Player()
            {
                Name = player1Name,
                Marker = "X",
                IsTurn = true
            };

            Console.WriteLine("Please enter Player's 2 name: ");
            string player2Name = Console.ReadLine();

            Player playerTwo = new Player()
            {
                Name = player2Name,
                Marker = "O",
                IsTurn = false
            };

            Console.Clear();

            Game game = new Game(playerOne, playerTwo);
            Player winner = game.Play();

            if (winner == null)
            {
                Console.WriteLine("It's a tie game.");
            }
            else
            {
                Console.WriteLine($"{winner.Name} is the winner!!");
            }
        }
    }
}
