using System;
using Xunit;
using static Lab04TicTacToe.Program;
using Lab04TicTacToe.Classes;


namespace Lab04TicTacToeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindHorizontalWinner()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;
            // ACT
            board.GameBoard[0, 0] = "X";
            board.GameBoard[0, 1] = "X";
            board.GameBoard[0, 2] = "X";
            // ASSERT
            bool answer = game.CheckForWinner(board);
            Assert.True(answer);
        }
        [Fact]
        public void CanFindVerticalWinner()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;
            // ACT
            board.GameBoard[0, 0] = "X";
            board.GameBoard[1, 0] = "X";
            board.GameBoard[2, 0] = "X";
            // ASSERT
            bool answer = game.CheckForWinner(board);
            Assert.True(answer);
        }
        [Fact]
        public void CanFindDiagnalWinner()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;
            // ACT
            board.GameBoard[0, 0] = "O";
            board.GameBoard[1, 1] = "O";
            board.GameBoard[2, 2] = "O";
            // ASSERT
            bool answer = game.CheckForWinner(board);
            Assert.True(answer);
        }
        [Fact]
        public void DoesPlayerSwitch()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            p1.IsTurn = true;
            Player p2 = new Player();
            p2.IsTurn = false;
            Game game = new Game(p1, p2);
            game.Board = board;
            // ACT

            // ASSERT
            game.SwitchPlayer();
            bool answer = p2.IsTurn;
            Assert.True(answer);
        }
        [Fact]

        public void PositionEqualsIndexPosition()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            p1.Marker = "X";
            p1.IsTurn = true;
            Player p2 = new Player();
            p2.IsTurn = false;
            Game game = new Game(p1, p2);
            game.Board = board;

            // ACT
            Position test = Player.PositionForNumber(3);
            // ASSERT

            Assert.Equal(0, test.Row);
            Assert.Equal(2, test.Column);


        }
        [Fact]
        public void NoWinner()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            // ACT
            string[,] testBoard = new string[,]{
                { "X", "X", "O"},
                {"O", "O", "X"},
                {"X", "X", "O"}
            };
            board.GameBoard = testBoard;
            game.Board = board;
            // ASSERT
            bool answer = game.CheckForWinner(board);
            Assert.False(answer);
        }
    }
}
