using Xunit;

namespace TicTacToe_Resources.Models
{
    public class Game_Tests
    {
        public Game_Tests()
        {
            _board = CreateEmptyBoard(_boardSize);
        }

        Game _game;

        private readonly int _boardSize = 3;
        private Board _board;
        private List<Player> _players;

        [Fact]
        public void Constructor_GameInitializes_BoardAndPlayersExist()
        {
            // Arrange

            // Act
            _game = new Game(_board, _players);

            // Assert
            IsValidBoard(_game.GameBoard);
            IsValidPlayersList(_game.Players);

            //TODO: Expect that an exception is thrown if players does not contain exactly two items
        }

        private Board CreateEmptyBoard(int boardSize)
        {
            return null;
        }

        private void IsValidBoard(Board board)
        {
            Assert.NotNull(board);
            Assert.Equal(_boardSize, board.Cells.GetLength(0));
            Assert.Equal(_boardSize, board.Cells.GetLength(1));
        }

        private void IsValidPlayersList(List<Player> players)
        {
            Assert.NotNull(players);
            Assert.Equal(_players, players);
        }
    }
}

