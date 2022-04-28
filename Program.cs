
int opponentTurn(){
    Random rnd = new Random();
    int rnumber = rnd.Next(1,9);
    return rnumber;
}
int yourTurn(){
    Console.Write("Pick a number between 1 and 9: ");
    string userInput = Console.ReadLine();
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
    board(one, two, three, four, five, six, seven, eight, nine);
    string symbol = "X";
    bool win = false;
    //for(int i = 0; i < 5; i++){
    while(win == false){
    //one==two & one==three & one == symbol | four==five & four==six & four == symbol | seven==eight & seven==nine & seven == symbol | one==four & one==seven & one == symbol | two==five & two==eight & two == symbol | three==six & three==nine & three == symbol | one==five & one==nine & one == symbol | three==five & three==seven & three == symbol ){
        int turn = opponentTurn();
        Console.WriteLine(turn);
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

    }
    Console.WriteLine("You Win!");
    //int xturn = yourTurn();
    //Console.WriteLine(xturn);
}

Main();