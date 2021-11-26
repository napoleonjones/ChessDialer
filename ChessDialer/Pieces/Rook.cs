﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDialer.Pieces
{
    public class Rook : Base
    {
        public Rook(char[,] board, int maxMoves) : base(board, maxMoves)
        {

        }
        public override long GetNumberOfPhoneNumbers(int startingRow, int startingColumn, int moves)
        {
            if (!IsValid(startingRow, startingColumn, moves))
            {
                return 0;
            }

            if (cachedResults.ContainsKey((startingRow, startingColumn, moves)))
            {
                return cachedResults[(startingRow, startingColumn, moves)];
            }

            if (moves == 1)
            {
                return 1;
            }

            long result = 0;

            var i = 1;
            while (i <= Board.GetLength(0) && i <= Board.GetLength(1))
            {
                result = result + GetNumberOfPhoneNumbers(startingRow + i, startingColumn, moves - 1)
                    + GetNumberOfPhoneNumbers(startingRow - i, startingColumn, moves - 1)
                    + GetNumberOfPhoneNumbers(startingRow, startingColumn + i, moves - 1)
                    + GetNumberOfPhoneNumbers(startingRow, startingColumn - i, moves - 1);

                    i = i + 1;
            };

            AddToCache(startingRow, startingColumn, moves, result);

            return result;
        }
    }
}
