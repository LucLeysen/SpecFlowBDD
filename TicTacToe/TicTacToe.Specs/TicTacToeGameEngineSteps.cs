using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TicTacToe.Game;

namespace TicTacToe.Specs
{
    [Binding]
    public class TicTacToeGameEngineSteps
    {
        private readonly GameEngine _gameEngine = new GameEngine();
        private string[,] _board;
        private string _result;

        [Given(@"I have a tic tac toe board")]
        public void GivenIHaveATicTacToeBoard()
        {
            _board = new string[3, 3];
        }

        [Given(@"the bord is empty")]
        public void GivenTheBordIsEmpty()
        {
            _board = new string[3, 3] {{"", "", ""}, {"", "", ""}, {"", "", ""}};
        }

        [When(@"I determine the outcome")]
        public void WhenIDetermineTheOutcome()
        {
            _result = _gameEngine.GetWinner(_board);
        }

        [Then(@"the result should be a stalemate")]
        public void ThenTheResultShouldBeAStalemate()
        {
            Assert.AreEqual("", _result);
        }

        [Given(@"the top row is all ""(.*)""")]
        public void GivenTheTopRowIsAll(string p0)
        {
            _board[0, 0] = p0;
            _board[0, 1] = p0;
            _board[0, 2] = p0;
        }

        [Then(@"the result is ""(.*)"" is the winner")]
        public void ThenTheResultIsIsTheWinner(string p0)
        {
            Assert.AreEqual(p0, _result);
        }

        [Given(@"the board looks like this")]
        public void GivenTheBoardLooksLikeThis (Table table)
        {
            for (var i = 0; i < table.RowCount; i++)
            {
                var row = table.Rows[i];

                _board[i, 0] = row[0];
                _board[i, 1] = row[1];
                _board[i, 2] = row[2];
            }
        }
    }
}