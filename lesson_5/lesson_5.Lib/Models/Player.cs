namespace Models;

public class Player{
    public string name{ get; set;}
    public int money{ get; set;}
    public int corrAnsNum{ get; set;}

    public Player(string name, int money)
    {
        if (name != null){
            this.name = name;
        } else {
            name = "anonymous";
        }
        this.money = money;
    }

    public void addMoney(){
        if (this. money == 0){
            this.money = 100;
            return;
        } else if (this. money == 200){
            this.money = 300;
            return;
        } else if (this. money == 300){
            this.money = 500;
            return;
        } else if (this. money == 64000){
            this.money = 125000;
            return;
        } else {
            this.money = this.money*2;
            return;
        }
    }
}