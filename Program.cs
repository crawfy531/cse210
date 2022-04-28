
int opponentTurn(){
    Random rnd = new Random();
    int rnumber = rnd.Next(1,9);
    return rnumber;
}

void Main(){

    int turn = opponentTurn();
    Console.WriteLine(turn);
}

Main();