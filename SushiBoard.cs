namespace SDKU_final;

public class SushiBoard
{
    private char[][] _board; //charset
    private int _rows;
    private int _columns;
    private int _boxes; //3x3

    public SushiBoard(char[][] board)
    {
        _board = board;
        _rows = board.Length;
        _columns = board[0].Length;
        _boxes = _rows / 3 * (_columns / 3); // 3x3 boxes in board
    }

    public bool IsValidSDKU()
    {
        //Validation of rows
        for (int row = 0; row < _rows; row++)
        {
            if (!IsValidRow(row))
                return false;
        }
        // Validation of columns
        for (int col = 0; col < _columns; col++)
        {
            if (!IsValidColumn(col))
                return false;
        }
        //Validation of 3x3 boxes
        for (int box = 0; box < _boxes; box++)
        {
            if (!IsValidBox(box))
                return false;
        }

        return true; //If sushiboard is valid.
    }
}
