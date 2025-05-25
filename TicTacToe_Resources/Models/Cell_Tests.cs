using Xunit;

namespace TicTacToe_Resources.Models
{
    public class Cell_Tests
    {
        public Cell_Tests()
        {
            
        }

        private Cell _cell;

        [Fact]
        public void Constructor_Instantiation_CellsIsSet()
        {
            // Arrange

            // Act
            _cell = new Cell();

            // Assert
            Assert.NotNull(_cell);
            Assert.Equal(string.Empty, _cell.Content);
        }

        [Theory]
        [InlineData("X")]
        [InlineData("O")]
        [InlineData("")]
        public void Content_CorrectValues_ContentIsSet(string input)
        {
            // Arrange
            _cell = new Cell();

            // Act
            _cell.Content = input;

            // Assert
            Assert.Equal(input, _cell.Content);
        }

        [Theory]
        [InlineData("x")]
        [InlineData("o")]
        [InlineData("0")]
        [InlineData("S")]
        [InlineData(".")]
        public void Content_IncorrectInput_ExceptionIsThrown(string input)
        {
            // Arrange
            _cell = new Cell();

            // Act
            Action act = () => _cell.Content = input;

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(() => act());
            Assert.Equal(Messages.ErrorMessageIncorrectCellContents, exception.Message);
        }
    }
}
