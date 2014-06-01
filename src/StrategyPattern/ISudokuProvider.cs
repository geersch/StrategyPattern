namespace CGeers.Sudoku
{
    public interface ISudokuProvider
    {
        void NewGame(int dimension);
        int ValueForCell(int row, int column);
    }
}
