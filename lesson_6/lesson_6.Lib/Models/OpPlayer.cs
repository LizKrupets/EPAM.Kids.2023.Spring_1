namespace TicTacToeLib;

public class OpPlayer : Player{

    public OpPlayer(Player p){
        if (p.chosenFigure == "X"){
            this.chosenFigure = "O";
        } else {
            this.chosenFigure = "X";
        }
    }
    public override int WhereToMove(string[] field){
        if (field[4] == " "){
            return 4;
        } else if ((field[4] == this.chosenFigure) && (field[0] == " ")){
            return 0;
        } else if ((field[4] == this.chosenFigure) && (field[2] == " ")){
            return 2;
        } else if ((field[4] == this.chosenFigure) && (field[6] == " ")){
            return 6;
        } else if ((field[4] == this.chosenFigure) && (field[8] == " ")){
            return 8;
        } else {
            Random rnd = new Random();
            int res = rnd.Next(0, 9);
            if (field[res] == " "){
                return res;
            } else {
                return WhereToMove(field);
            }
        }
    }
}