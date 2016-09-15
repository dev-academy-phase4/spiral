﻿using Spiral;
using Xunit;

namespace SpiralTests
{
    public class BoardTests
    {
        [Fact]
        public void BoardGeneratedFiveByFive ()
        {
            // Arrange & Act
            var board = new Board(5, 5);

            // Assert
            Assert.Equal(5, board.Cells.Length);
            Assert.Equal(5, board.Cells[0].Length);
        }

        [Fact]
        public void BoardGeneratedSixByTwo ()
        {
            // Arrange
            string expected = "..\n..\n..\n..\n..\n..\n";

            // Act
            var board = new Board(6, 2);
            var actual = board.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
