using Models;
using Newtonsoft.Json;

class Program {
    static void Main(string[] args){
        Game game = new Game();           
        game.Start();
                
        Console.WriteLine("Конец игры");
    }
}