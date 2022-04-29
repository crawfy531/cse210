//cse210-01
//Ponder 1
//Jennifer Crawford

int turnStarter(){
    Random rnd = new Random();
    int flip = rnd.Next(1,2);
    return flip;
}

int opponentTurn(){
    Console.WriteLine("Oppenent's Turn");
    Random rnd = new Random();
    int rnumber = rnd.Next(1,9);
    return rnumber;
}
int yourTurn(){
    string userInput = "-1";
    while(userInput != "1" && userInput != "2" && userInput != "3"  && userInput != "4"  && userInput != "5"  && userInput != "6"  && userInput != "7"  && userInput != "8" && userInput != "9"){
        Console.WriteLine("Your Turn");
        Console.Write("Pick a number between 1 and 9: ");
        userInput = Console.ReadLine();
    }
    int yTurn = int.Parse(userInput);
    return yTurn;
    }
void board(string one, string two, string three, string four, string five, string six, string seven, string eight, string nine){
    Console.WriteLine($"{one}|{two}|{three}\n-+-+-\n{four}|{five}|{six}\n-+-+-\n{seven}|{eight}|{nine}");
    return;
}


void Main(){
    string one = "1";
    string two = "2";
    string three = "3";
    string four = "4";
    string five = "5";
    string six = "6";
    string seven = "7";
    string eight = "8";
    string nine = "9";
    string symbol = " ";
    int turn = 0;
    List<int> usedNumbers = new List<int>();
    Console.WriteLine("Lets play some Tic-Tack-Toe!");
    int whoseTurn = turnStarter();
    bool win = false;
    bool tie = false;
    while(win == false){
        if (usedNumbers.Count == 9){
            tie = true;
            break;
        }
        if(whoseTurn % 2 == 0){
            while (usedNumbers.Contains(turn)){
            turn = yourTurn();
            }
            symbol = "X";

        }
        else{
            while (usedNumbers.Contains(turn)){
            turn = opponentTurn();
            }
            symbol = "O";
        }
        usedNumbers.Add(turn);
        switch(turn){
            case 1:
            one = symbol;
            break;

            case 2:
            two = symbol;
            break;

            case 3:
            three = symbol;
            break;

            case 4:
            four = symbol;
            break;

            case 5:
            five = symbol;
            break;

            case 6:
            six = symbol;
            break;

            case 7:
            seven = symbol;
            break;

            case 8:
            eight = symbol;
            break;

            case 9:
            nine = symbol;
            break;
        }

        board(one, two, three, four, five, six, seven, eight, nine);
        if(one==two & one==three & one == symbol | four==five & four==six & four == symbol | seven==eight & seven==nine & seven == symbol | one==four & one==seven & one == symbol | two==five & two==eight & two == symbol | three==six & three==nine & three == symbol | one==five & one==nine & one == symbol | three==five & three==seven & three == symbol){
            win = true;
        }
        ++ whoseTurn;

    }
    if(tie == true){
        Console.WriteLine("Tie.");
    }
    else if(symbol == "X"){
        Console.WriteLine("You Win!");
    }
    else{
        Console.WriteLine("You Lose...");
    }
}

Main();