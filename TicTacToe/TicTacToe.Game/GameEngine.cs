namespace TicTacToe.Game
{
    public class GameEngine
    {
        public string GetWinner(string[,] board)
        {
            for (var i = 0; i < 3; i++)
            {
                if (!HasEmptySpotsInRow(i, board))
                {
                    if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    {
                        return board[i, 0];
                    }
                }
            }

            for (var i = 0; i < 3; i++)
            {
                if (!HasEmptySpotsInCol(i, board))
                {
                    if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    {
                        return board[0, i];
                    }
                }
            }

            if(board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0];
            }

            return "";
        }

        private static bool HasEmptySpotsInRow (int i, string[,] board)
        {
            return board[i, 0] == "" || board[i, 1] == "" || board[i, 2] == "";
        }

        private static bool HasEmptySpotsInCol (int i, string[,] board)
        {
            return board[0, i] == "" || board[1, i] == "" || board[2, i] == "";
        }
    }
}