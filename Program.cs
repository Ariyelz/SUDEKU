namespace SDKU_final;

class Program
{
    static void Main()
    {
        //Creating SDKU board 2d char-array (I need to look more into this and how to use it in other things)
        char[][] board = new char[][]
        {
            new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };
        //Initialising SushiBoard with given SDKU charset/Board
        SushiBoard SdkuBoard = new SushiBoard(board);
        
        //Checking if the board is valid
        bool IsValid = SdkuBoard.IsValidSDKU();

        if (IsValid)
        {
            Console.WriteLine("Sashimi/suzuki/sodoki/sudkoku is valid");
        }
        else
        {
            Console.WriteLine("Not a valid soshimi/sushi/sodeku board");
        }
    }
}