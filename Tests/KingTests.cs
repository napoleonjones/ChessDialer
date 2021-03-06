using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessDialer.Pieces;

namespace Tests
{
    [TestClass]
    public class KingTests
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
            var king = new King(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 0;

            var result = king.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt0_Returns0()
        {
            var maxMoves = 7;
            var king = new King(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 1;

            var result = king.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAtHashTag_Returns0()
        {
            var maxMoves = 7;
            var king = new King(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 2;

            var result = king.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt2With2Moves_Returns5()
        {
            var maxMoves = 2;
            var king = new King(board, maxMoves);
            var startingRow = 0;
            var startingColumn = 1;

            var result = king.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 5;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt2With3Moves_Returns24()
        {
            var maxMoves = 3;
            var king = new King(board, maxMoves);
            var startingRow = 0;
            var startingColumn = 1;

            var result = king.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 24;

            Assert.AreEqual(expectedResult, result);
        }
    }
}
