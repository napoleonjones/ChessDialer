using System;
using System.Collections.Generic;

namespace ChessDialer.Pieces
{
    public abstract class Base
    {
        public static int max = (int)Math.Pow(10, 9) + 7;
        public char[,] Board { get; set; }
        public int MaxMoves { get; set; }

        protected Dictionary<(int, int, int), long> cachedResults = new Dictionary<(int, int, int), long>();

        public Base(char[,] board, int maxMoves)
        {
            if (board == null)
            {
                throw new ArgumentNullException($"Board cannot be null");
            }
                
            Board = board;
            MaxMoves = maxMoves;
        }

        public abstract long GetNumberOfPhoneNumbers(int startingRow, int startingColumn, int moves);

        protected bool IsValid(int startingRow, int startingColumn, int moves)
        {
            if (moves < 1 || startingRow < 0 || startingColumn < 0 ||
                startingRow > Board.GetLength(0) - 1 || startingColumn > Board.GetLength(1) - 1 ||
                Board[startingRow, startingColumn] == '#' || Board[startingRow, startingColumn] == '*')
            {
                return false;
            }

            if (moves == MaxMoves && (Board[startingRow, startingColumn] == '0' || Board[startingRow, startingColumn] == '1'))
            {
                return false;
            }

            return true;
        }

        protected void AddToCache(int startingRow, int startingColumn, int moves, long result)
        {
            if (!cachedResults.ContainsKey((startingRow, startingColumn, moves)))
            {
                cachedResults.Add((startingRow, startingColumn, moves), result);
            }
        }
    }
}