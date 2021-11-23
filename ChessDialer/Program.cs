using ChessDialer.Pieces;
using System;

namespace ChessDialer
{
    public class Program
    {
        private static char[,] board = new char[4, 3]
        {
        {'1', '2', '3' },
        {'4', '5', '6' },
        {'7', '8', '9' },
        {'*', '0', '#' }
        };

        static void Main(string[] args)
        {
            var maxMoves = 7;
            long pawnResults = 0;
            long knightResults = 0;
            long bishopResults = 0;
            long rookResults = 0;
            long queenResults = 0;
            long kingResults = 0;

            var pawn = new Pawn(board, maxMoves);
            var knight = new Knight(board, maxMoves);
            var bishop = new Bishop(board, maxMoves);
            var rook = new Rook(board, maxMoves);
            var queen = new Queen(board, maxMoves);
            var king = new King(board, maxMoves);

            for(int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    pawnResults += pawn.GetNumberOfPhoneNumbers(row, col, maxMoves);
                    knightResults += knight.GetNumberOfPhoneNumbers(row, col, maxMoves);
                    bishopResults += bishop.GetNumberOfPhoneNumbers(row, col, maxMoves);
                    rookResults += rook.GetNumberOfPhoneNumbers(row, col, maxMoves);
                    queenResults += queen.GetNumberOfPhoneNumbers(row, col, maxMoves);
                    kingResults += king.GetNumberOfPhoneNumbers(row, col, maxMoves);
                }
            }

            Console.WriteLine($"Pawn: {pawnResults}");
            Console.WriteLine($"Knight: {knightResults}");
            Console.WriteLine($"Bishop: {bishopResults}");
            Console.WriteLine($"Rook: {rookResults}");
            Console.WriteLine($"Queen: {queenResults}");
            Console.WriteLine($"King: {kingResults}");
        }
    }
}
