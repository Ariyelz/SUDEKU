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

    private bool IsValidRow(int row)
    {
        HashSet<char> set = new HashSet<char>(); //Using hashset to track unique characters in row.
        for (int col = 0; col < _columns; col++)
        {
            char block = _board[row][col]; // Gets char in block for x row,col
            if (block != '-') // If block is not '-'
            {
                if (set.Contains(block))
                    return false; //  Duplicate in row
                set.Add(block); // adding block to Hashset
            }
        }

        return true; //row is valid
    }

    private bool IsValidColumn(int column)
    {
        HashSet<char> set = new HashSet<char>();
        for (int row = 0; row < _rows; row++)
        {
            char block = _board[row][column];
            if (block != '-')
            {
                if (set.Contains(block))
                    return false; //Duplicate in column
                set.Add(block);
            }
        }

        return true;
    }

    private bool IsValidBox(int box)
    {
        HashSet<char> set = new HashSet<char>();
        int startRow = (box / 3) * 3; //Startrow in box
        int startColumn = (box % 3) * 3; // Startcolumn in box

        for (int row = 0; row < startRow + 3; row++)
        {
            for (int col = startColumn; col < startColumn + 3; col++)
            {
                char block = _board[row][col];
                if (block != '-')
                {
                    if (set.Contains(block))
                        return false; //Duplicate in 3x3 box
                    set.Add(block);
                }
            }
        }

        return true;
    }
}
