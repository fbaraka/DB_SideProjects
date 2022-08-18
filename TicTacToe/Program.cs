// TicTacToe


Console.WriteLine("Let's play a game of Tic Tac Toe");



/*TODO: Setup the board 
  
  
    - each square on the board will be associated to a list for now 
    - have two users and possibly switch back between the two 
        - one as X the other as O
    - build out conditions for winning?
        - all the combinations for player 1 to win? 
        - can think of 8 combos for winning 
               - that is the three verticals, three horizontals, and two diagonals 
    - if there is a win tally it for user 1 or 2 
    - would you like to play again loop
    - show the final score. 
 
 */

Console.WriteLine("Welcome to Tic Tac Toe!");
Console.Write("Player X, enter your name: ");
string playerOne = Console.ReadLine();
Console.Write("Player O, enter your name: ");
string playerTwo = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"~-~-{playerOne} VS {playerTwo}~-~-");
Console.WriteLine();


// build the board
// left variable spots for the list of empty x and o


// create an array to store the x and os in

char[] boardMarks = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

bool gameOver = false;
int drawCounter = 0;

do
{
 

    Console.Clear();
    MakeBoard(boardMarks);

    bool playerOneMoveOver = false;
    while (!playerOneMoveOver)
    {
        Console.Write($"{playerOne}, select a spot to place your X! ");
        int userInput = validEntry();


        boardMarks[userInput - 1] = 'X';
        playerOneMoveOver = true;
    }

    drawCounter++;
    gameOver = CheckWinningCombo(boardMarks, drawCounter);



    Console.Clear();
    MakeBoard(boardMarks);

    bool playerTwoMoveOver = false;
    while (!playerTwoMoveOver)
    {
        Console.Write($"{playerTwo}, select a spot to place your O! ");
        int userInput = validEntry();


        boardMarks[userInput - 1] = 'O';
        playerTwoMoveOver = true;
    }

    drawCounter++;
    gameOver = CheckWinningCombo(boardMarks, drawCounter);


} while (!gameOver);




static void MakeBoard(char[] _boardMarks)


{

    Console.WriteLine("==========================================================================");
    Console.WriteLine();
    Console.WriteLine($"       |     |      ");
    Console.WriteLine($"    {_boardMarks[0]}  |  {_boardMarks[1]}  |  {_boardMarks[2]}  ");
    Console.WriteLine($"  _____|_____|_____ ");
    Console.WriteLine($"       |     |      ");
    Console.WriteLine($"    {_boardMarks[3]}  |  {_boardMarks[4]}  |  {_boardMarks[5]}  ");
    Console.WriteLine($"  _____|_____|_____ ");
    Console.WriteLine($"       |     |      ");
    Console.WriteLine($"    {_boardMarks[6]}  |  {_boardMarks[7]}  |  {_boardMarks[8]}  ");
    Console.WriteLine($"       |     |      ");
    Console.WriteLine();
    Console.WriteLine("==========================================================================");
    Console.WriteLine();

}

// adding our int validator 

static int validEntry()
{
    int userNum = 0;
    bool oneTwoThree = false;
    do
    {
        bool tryagain = true;
        while (tryagain)
        {
            Console.Write("Enter a number to test: ");
            string userInput = Console.ReadLine();
            bool vaild = int.TryParse(userInput, out userNum);
            if (vaild)
            {
                tryagain = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid integer, dummy");
            }
        }
        if (userNum == 1 || userNum == 2 || userNum == 3 || userNum == 4 || userNum == 5 || userNum == 6 || userNum == 7 || userNum == 8 || userNum == 9)
        {
            oneTwoThree = true;
        }
        else
        {
            Console.WriteLine("Pick 1-9 you idiot.");
        }
    } while (!oneTwoThree);

    return userNum;
}


// making a function to check results

static bool CheckWinningCombo(char[] _boardMarks, int _drawCounter)
{

    while (true)
    {
        if ((_boardMarks[0] == _boardMarks[1]) && (_boardMarks[1] == _boardMarks[2])) // 3 horizontal win combos
        {
            return true;
        }
        else if ((_boardMarks[3] == _boardMarks[4]) && (_boardMarks[4] == _boardMarks[5]))
        {
            return true;

        }
        else if ((_boardMarks[6] == _boardMarks[7]) && (_boardMarks[7] == _boardMarks[8]))
        {
            return true;

        }
        else if ((_boardMarks[0] == _boardMarks[3]) && (_boardMarks[3] == _boardMarks[6])) // 3 vertical win combos
        {
            return true;

        }
        else if ((_boardMarks[1] == _boardMarks[4]) && (_boardMarks[4] == _boardMarks[7]))
        {
            return true;

        }
        else if ((_boardMarks[2] == _boardMarks[5]) && (_boardMarks[5] == _boardMarks[8]))
        {
            return true;

        }
        else if ((_boardMarks[0] == _boardMarks[4]) && (_boardMarks[4] == _boardMarks[8])) // 2 diagonal win combos
        {
            return true;

        }
        else if ((_boardMarks[2] == _boardMarks[4]) && (_boardMarks[4] == _boardMarks[6]))
        {
            return true;

        }
        else if (_drawCounter == 9)
        {

            return true;
        }
        else
        {
            return false;
        }

    }

}