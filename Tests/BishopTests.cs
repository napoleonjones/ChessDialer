using ChessDialer.Pieces;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tests
{
    [TestClass]
    public class BishopTests
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
            var bishop = new Bishop(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 0;

            var result = bishop.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt0_Returns0()
        {
            var maxMoves = 7;
            var bishop = new Bishop(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 1;

            var result = bishop.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAtHashTag_Returns0()
        {
            var maxMoves = 7;
            var bishop = new Bishop(board, maxMoves);
            var startingRow = 3;
            var startingColumn = 2;

            var result = bishop.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt2AndMaxMoves2_Returns2()
        {
            var maxMoves = 2;
            var bishop = new Bishop(board, maxMoves);
            var startingRow = 0;
            var startingColumn = 1;

            var result = bishop.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 2;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt2AndMaxMoves3_Returns4()
        {
            var maxMoves = 3;
            var bishop = new Bishop(board, maxMoves);
            var startingRow = 0;
            var startingColumn = 1;

            var result = bishop.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 4;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt5AndMaxMoves2_Returns4()
        {
            var maxMoves = 2;
            var bishop = new Bishop(board, maxMoves);
            var startingRow = 1;
            var startingColumn = 1;

            var result = bishop.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            var expectedResult = 4;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void BoardSize_WhenStartsAt8With2Moves_Returns4()
        {
            var maxMoves = 2;
            var rook = new Bishop(board2, maxMoves);

            var startingRow = 2;
            var startingColumn = 1;

            var expectedResult = 4;

            var result = rook.GetNumberOfPhoneNumbers(startingRow, startingColumn, maxMoves);

            Assert.AreEqual(expectedResult, result);
        }
    }
}