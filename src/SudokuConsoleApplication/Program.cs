using System;
using CGeers.Sudoku;

namespace SudokuConsoleApplication
{
    class Program
    {
        private static void GeneratePuzzle(SudokuGrid sudokuGrid,
            ISudokuProvider sudokuProvider)
        {
            sudokuGrid.SudokuProvider = sudokuProvider;
            sudokuGrid.NewGame();
            Console.WriteLine(sudokuGrid.ToString());
        }

        static void Main()
        {
            SudokuGrid sudokuGrid = new SudokuGrid();

            // Geneate a puzzle populated with random numbers.
            GeneratePuzzle(sudokuGrid, new RandomNumbersSudokuProvider());

            // Generate a puzzle populated with the number eight.
            GeneratePuzzle(sudokuGrid, new NumberEightSudokuProvider());

            // Generate a puzzle populated with the number one.
            GeneratePuzzle(sudokuGrid, new NumberOneSudokuProvider());

            Console.WriteLine("\n\rPress return to exit.\n\r");
            Console.ReadLine();
        }
    }
}
