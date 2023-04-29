namespace TicTacToeLib;
using TicTacToeLib;


public class RPlayer : Player{

    public RPlayer(string fig){

        if (fig == "X") {
            chosenFigure = fig;
            } else {
                chosenFigure = "O";
            }
    }

    public override bool Move(string[] field){
        return base.Move(field);
    }

    public override int WhereToMove(string[] field){
        string ans = Console.ReadLine();
        string xstr = Convert.ToString(ans[0]);
        string ystr = Convert.ToString(ans[2]);  

        int x;
        int y;  

        while ( (!int.TryParse(xstr, out x)) || (!int.TryParse(ystr, out y)) || (3*(y-1) + x - 1)>8){
            Console.WriteLine("Invalid input");
            ans = Console.ReadLine();
            xstr = Convert.ToString(ans[0]);
            ystr = Convert.ToString(ans[2]);
        } 
        
        int res = 3*(y-1) + x - 1;

        if (field[res] == " "){
            return res;
        } else {
            Console.WriteLine("The cell is not empty");
            return WhereToMove(field);
        }
    }
}