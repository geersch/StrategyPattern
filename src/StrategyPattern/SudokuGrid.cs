using System;
using System.Text;
using System.Globalization;

namespace CGeers.Sudoku
{
    public class SudokuGrid
    {
        private static int dimension = 9;

        private int[,] cells = new int[dimension, dimension];        

        public ISudokuProvider SudokuProvider { get; set; }

        public void NewGame()
        {
            if (SudokuProvider != null)
            {
                SudokuProvider.NewGame(dimension);
                for (int row = 0; row < dimension; row++)
                {
                    for (int column = 0; column < dimension; column++)
                    {
                        cells[row, column] = SudokuProvider.ValueForCell(row, column);
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("Please specify a Sudoku Provider.");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Sudoku puzzle\n");
            result.Append("-------------\n\n");
            for (int row = 0; row < dimension; row++)
            {
                result.Append("Row " + row.ToString() + ":\t\t");
                for (int column = 0; column < dimension; column++)
                {
                    result.Append(String.Format(CultureInfo.InvariantCulture,
                        "{0}  ", cells[row, column]));                                        
                }
                result.Append("\n");
            }
            
            return result.ToString();
        }
    }
}
