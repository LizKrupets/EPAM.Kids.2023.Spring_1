namespace TicTacToeLib;

public abstract class Player{
    public string chosenFigure;




    virtual public bool Move(string[] field){//print field; decide where to move; check if the game is finished 
        Game.CreateField(field);
        int res = WhereToMove(field);
        field[res] = this.chosenFigure;
        return Game.CheckIfFinished(field);
    }

    public abstract int WhereToMove(string[] field);// ask player where to move our decide where to move

}