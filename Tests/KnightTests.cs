using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessDialer.Pieces;

namespace Tests
{
    [TestClass]
    public class KnightTests
    {
        private static char[,] board = new char[4, 3]
        {
        {'1', '2', '3' },
        {'4', '5', '6' },
        {'7', '8', '9' },
        {'*', '0', '#' }
        };


        [TestMethod]
        public void WhenStartsAt5_Returns0()
        {
            var knight = new Knight(board, 7);
            var startingRow = 1;
            var startingColumn = 1;

            var result = knight.GetNumberOfPhoneNumbers(startingRow, startingColumn, 7);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAtStar_Returns0()
        {
            var knight = new Knight(board, 7);
            var startingRow = 3;
            var startingColumn = 0;

            var result = knight.GetNumberOfPhoneNumbers(startingRow, startingColumn, 7);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt0_Returns0()
        {
            var knight = new Knight(board, 7);
            var startingRow = 3;
            var startingColumn = 1;

            var result = knight.GetNumberOfPhoneNumbers(startingRow, startingColumn, 7);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAtHashTag_Returns0()
        {
            var knight = new Knight(board, 7);
            var startingRow = 3;
            var startingColumn = 2;

            var result = knight.GetNumberOfPhoneNumbers(startingRow, startingColumn, 7);

            var expectedResult = 0;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt2With2Moves_Returns2()
        {
            var knight = new Knight(board, 2);
            var startingRow = 0;
            var startingColumn = 1;

            var result = knight.GetNumberOfPhoneNumbers(startingRow, startingColumn, 2);

            var expectedResult = 2;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt2With3Moves_Returns4()
        {
            var knight = new Knight(board, 3);
            var startingRow = 0;
            var startingColumn = 1;

            var result = knight.GetNumberOfPhoneNumbers(startingRow, startingColumn, 3);

            var expectedResult = 4;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt2With4Moves_Returns10()
        {
            var knight = new Knight(board, 4);
            var startingRow = 0;
            var startingColumn = 1;

            var result = knight.GetNumberOfPhoneNumbers(startingRow, startingColumn, 4);

            var expectedResult = 10;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void WhenStartsAt2With5Moves_Returns20()
        {
            var knight = new Knight(board, 5);
            var startingRow = 0;
            var startingColumn = 1;

            var result = knight.GetNumberOfPhoneNumbers(startingRow, startingColumn, 5);

            var expectedResult = 20;

            Assert.AreEqual(expectedResult, result);
        }
    }
}