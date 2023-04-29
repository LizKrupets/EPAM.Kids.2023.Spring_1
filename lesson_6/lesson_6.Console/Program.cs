using TicTacToeLib;

class Program {
    static void Main(string[] args){
        bool playerWantToPlay = true;

        while(playerWantToPlay){
            Game game = new Game();
            playerWantToPlay = game.Start();
        }
    }
}