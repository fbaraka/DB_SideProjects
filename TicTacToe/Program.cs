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


// create a list to store the x and os in
Dictionary<int, string> boardMarks = new Dictionary<int, string>();
boardMarks.Add(1, "1");
boardMarks.Add(2, "2");
boardMarks.Add(3, "3");
boardMarks.Add(4, "4");
boardMarks.Add(5, "5");
boardMarks.Add(6, "6");
boardMarks.Add(7, "7");
boardMarks.Add(8, "8");
boardMarks.Add(9, "9");



MakeBoard(boardMarks);

static void MakeBoard(Dictionary<int, string> _boardMarks)


{
    Console.WriteLine($"       |     |      ");
    Console.WriteLine($"    {_boardMarks[1]}  |  {_boardMarks[2]}  |  {_boardMarks[3]}  ");
    Console.WriteLine($"  _____|_____|_____ ");
    Console.WriteLine($"       |     |      ");
    Console.WriteLine($"    {_boardMarks[4]}  |  {_boardMarks[5]}  |  {_boardMarks[6]}  ");
    Console.WriteLine($"  _____|_____|_____ ");
    Console.WriteLine($"       |     |      ");
    Console.WriteLine($"    {_boardMarks[7]}  |  {_boardMarks[8]}  |  {_boardMarks[9]}  ");
    Console.WriteLine($"       |     |      ");

}
