using System;

namespace CGeers.Sudoku
{    
    public class RandomNumbersSudokuProvider : ISudokuProvider
    {
        private int[,] grid;

        #region ISudokuProvider Members

        public void NewGame(int dimension)
        {
            grid = new int[dimension, dimension];

            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j] = random.Next(1, 10);
                }
            }
        }

        public int ValueForCell(int row, int column)
        {
            if (grid != null)
            {
                return grid[row, column];
            }
            else
            {
                throw
                    new InvalidOperationException
                        ("Please call the NewGame(int dimension) method first to initialize the game.");
            }
        }

        #endregion
    }    
}
