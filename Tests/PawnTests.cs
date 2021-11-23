using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessDialer.Pieces;

namespace Tests
{
    [TestClass]
    public class PawnTests
    {
        private static char[,] board = new char[4, 3]
            {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' },
                {'*', '0', '#' }
            };

        [TestMethod]
        public void WhenStartsAt5AndMoves2_Returns1()
        {
            var maxMoves = 2;
            var startingRow = 1;
            var startingColumn = 1;


            var pawn = new Pawn(board, maxMoves);

            var result = pawn.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 1;

            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void WhenStartsAt4AndMoves3_Returns0()
        {
            var maxMoves = 3;
            var startingRow = 1;
            var startingColumn = 0;

            var pawn = new Pawn(board, maxMoves);

            var result = pawn.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void WhenStartsAt7AndMoves4_Returns0()
        {
            var maxMoves = 4;
            var startingRow = 2;
            var startingColumn = 0;

            var pawn = new Pawn(board, maxMoves);

            var result = pawn.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);

        }
    }
}