using System;

namespace CGeers.Sudoku
{
    // Provided for illustrative purposes
    public class NumberEightSudokuProvider : ISudokuProvider
    {
        #region ISudokuProvider Members

        public void NewGame(int dimension)
        { }

        public int ValueForCell(int row, int column)
        {
            return 8;
        }

        #endregion    
    }
}
