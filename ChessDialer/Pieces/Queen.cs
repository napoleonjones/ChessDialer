namespace ChessDialer.Pieces
{
    public class Queen : Base
    {
        public Queen(char[,] board, int maxMoves) : base(board, maxMoves)
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

            var result = GetNumberOfPhoneNumbers(startingRow + 1, startingColumn + 1, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow + 1, startingColumn - 1, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow - 1, startingColumn + 1, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow - 1, startingColumn - 1, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow + 2, startingColumn + 2, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow + 2, startingColumn - 2, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow - 2, startingColumn + 2, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow - 2, startingColumn - 2, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow + 1, startingColumn, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow + 2, startingColumn, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow + 3, startingColumn, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow - 1, startingColumn, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow - 2, startingColumn, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow - 3, startingColumn, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow, startingColumn + 1, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow, startingColumn + 2, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow, startingColumn - 1, moves - 1)
            + GetNumberOfPhoneNumbers(startingRow, startingColumn - 2, moves - 1);

            AddToCache(startingRow, startingColumn, moves, result);

            return result;
        }
    }
}