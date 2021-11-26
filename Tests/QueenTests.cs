using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessDialer.Pieces;

namespace Tests
{
    [TestClass]
    public class QueenTests
    {
        private static char[,] board = new char[4, 3]
        {
        {'1', '2', '3' },
        {'4', '5', '6' },
        {'7', '8', '9' },
        {'*', '0', '#' }
        };

        private static char[,] board2 = new char[5, 3]
        {
        {'1', '2', '3' },
        {'4', '5', '6' },
        {'7', '8', '9' },
        {'1', '2', '3' },
        {'*', '0', '#' }
        };

        [TestMethod]
        public void WhenStartsAtStar_Returns0()
        {
            var maxMoves = 7;
            var queen = new Queen(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 0;

            var result = queen.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt0_Returns0()
        {
            var maxMoves = 7;
            var queen = new Queen(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 1;

            var result = queen.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAtHashTag_Returns0()
        {
            var maxMoves = 7;
            var queen = new Queen(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 2;

            var result = queen.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt2With2Moves_Returns7()
        {
            var maxMoves = 2;
            var queen = new Queen(board, maxMoves);
            var startingRow = 0;
            var startingColumn = 1;

            var result = queen.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 7;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void BoardSize_WhenStartsAt8With2Moves_Returns10()
        {
            var maxMoves = 2;
            var rook = new Queen(board2, maxMoves);

            var startingRow = 2;
            var startingColumn = 1;

            var expectedResult = 10;

            var result = rook.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            Assert.AreEqual(expectedResult, result);
        }
    }
}