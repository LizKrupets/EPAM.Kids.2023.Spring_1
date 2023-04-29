namespace TicTacToeLib;
using TicTacToeLib;

public class Game{
    OpPlayer opPlayer;
    RPlayer player;
    bool isFinished;
    string[] field;

    

    public Game(){
        isFinished = false;
        player = new RPlayer("O");

        field = new string[9];
        for(int i = 0; i < 9; i++){
            field[i] = " ";
        }
    }

    static public void CreateField(string[] field){
        Console.Write("\n{0} | {1} | {2}\n----------\n{3} | {4} | {5}\n----------\n{6} | {7} | {8}\n", field[0], field[1], field[2], field[3], field[4], field[5], field[6], field[7], field[8]);
    }

    static public bool CheckIfFinished(string[] field){
        if (((field[0] == field[1]) && (field[1] == field[2]) && (field[2] != " ")) ||
            ((field[3] == field[4]) && (field[4] == field[5]) && (field[5] != " ")) ||
            ((field[6] == field[7]) && (field[7] == field[8]) && (field[8] != " ")) ||

            ((field[0] == field[3]) && (field[3] == field[6]) && (field[6] != " ")) ||
            ((field[1] == field[4]) && (field[4] == field[7]) && (field[7] != " ")) ||
            ((field[2] == field[5]) && (field[5] == field[8]) && (field[8] != " ")) ||
            
            ((field[0] == field[4]) && (field[4] == field[8]) && (field[8] != " ")) ||
            ((field[6] == field[4]) && (field[4] == field[2]) && (field[2] != " ")))   {
                return true;
            } else {
                return false;
            }
    }

    public bool Play(){
        while(!this.isFinished){
            if (this.isFinished = player.Move(this.field)){
                break;
            }
            
            this.isFinished = opPlayer.Move(this.field);
            
        }

        Game.CreateField(this.field);
        Console.WriteLine("Game over. Do you want to play again? ");
        string ans = Console.ReadLine();

        if (ans == "Yes"){
           return true;
        } else {
            Console.WriteLine("Game over");
            return false;
        }
    }


    public bool Start(){

        while (true){
            Console.WriteLine("Choose X or O");
            string fig = Console.ReadLine();

            if (fig == "X"){
                player.chosenFigure = "X";
                break;
            } else if (fig == "O"){
                player.chosenFigure = "O";
                break;
            } else {
                Console.WriteLine("Invalid input");
                continue;
            }
        }

        opPlayer = new OpPlayer(player);

        Console.WriteLine("Enter cell location in XxY format, for example 1x1.");//instructions

        return this.Play();
        
    }
}