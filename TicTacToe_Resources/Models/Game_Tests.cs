using Xunit;

namespace TicTacToe_Resources.Models
{
    public class Game_Tests
    {
        public Game_Tests()
        {
            _board = CreateEmptyBoard(_boardSize);
            _players = CreateDummyPlayersList();
        }

        Game _game;

        private readonly int _boardSize = 3;
        private Board _board;
        private List<Player> _players;

        [Fact]
        public void Constructor_ValidBoadWithCells_BoardAndPlayersExist()
        {
            // Arrange

            // Act
            _game = new Game(_board, _players);

            // Assert
            IsValidBoard(_game.GameBoard);
            IsValidPlayersList(_game.Players);
        }

        [Fact]
        public void Constructor_TooManyPlayers_ExceptionIsThrown()
        {
            // Arrange
            _players.Add(new Player(PlayerType.Human));

            // Act
            Action act = () => new Game(_board, _players);

            // Assert
            var exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(Messages.ErrorMessageTooManyPlayers, exception.Message);
        }

        [Fact]
        public void Constructor_TooFewPlayers_ExceptionIsThrown()
        {
            // Arrange
            _players = new List<Player> { new Player(PlayerType.Human) };

            // Act
            Action act = () => new Game(_board, _players);

            // Assert
            var exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(Messages.ErrorMessageTooFewPlayers, exception.Message);
        }

        [Fact]
        public void Constructor_PlayersNotInstanciated_ExceptionIsThrown()
        {
            // Arrange
            _players = null;

            // Act
            Action act = () => new Game(_board, _players);

            // Assert
            var exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(Messages.ErrorMessagePlayersNotInitialized, exception.Message);
        }

        [Fact]
        public void Constructor_PlayersEmpty_ExceptionIsThrown()
        {
            // Arrange
            _players = new List<Player>();

            // Act
            Action act = () => new Game(_board, _players);

            // Assert
            var exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(Messages.ErrorMessagePlayersNotInitialized, exception.Message);
        }


        private List<Player> CreateDummyPlayersList()
        {
            return new List<Player>
            {
                new Player(PlayerType.Human),
                new Player(PlayerType.Computer)
            };
        }

        private Board CreateEmptyBoard(int boardSize)
        {
            var cells = CreateEmptyCells(_boardSize);
            return new Board(_boardSize, cells);
        }

        private Cell[,] CreateEmptyCells(int boardSize)
        {
            var cells = new Cell[boardSize, boardSize];

            return cells;
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
            Assert.Equal(2, players.Count);
            Assert.Equal(_players, players);
        }
    }
}

