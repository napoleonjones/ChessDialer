using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessDialer.Pieces;

namespace Tests
{
    [TestClass]
    public class RookTests
    {
        private static char[,] board = new char[4, 3]
        {
        {'1', '2', '3' },
        {'4', '5', '6' },
        {'7', '8', '9' },
        {'*', '0', '#' }
        };

        [TestMethod]
        public void WhenStartsAtStar_Returns0()
        {
            var maxMoves = 7;
            var rook = new Rook(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 0;

            var result = rook.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt0_Returns0()
        {
            var maxMoves = 7;
            var rook = new Rook(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 1;

            var result = rook.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAtHashTag_Returns0()
        {
            var maxMoves = 7;
            var rook = new Rook(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 2;

            var result = rook.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void WhenStartsAt2With2Moves_Returns5()
        {
            var maxMoves = 2;
            var rook = new Rook(board, maxMoves);

            var startingRow = 0;
            var startingColumn = 1;

            var expectedResult = 5;

            var result = rook.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void WhenStartsAt2With3Moves_Returns21()
        {
            var maxMoves = 3;
            var rook = new Rook(board, maxMoves);

            var startingRow = 0;
            var startingColumn = 1;

            var expectedResult = 21;

            var result = rook.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt2With4Moves_Returns91()
        {
            var maxMoves = 4;
            var rook = new Rook(board, maxMoves);

            var startingRow = 0;
            var startingColumn = 1;

            var expectedResult = 91;

            var result = rook.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            Assert.AreEqual(expectedResult, result);
        }

    }
}