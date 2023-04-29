namespace Models;
using Models;
using Newtonsoft.Json;
using System.Text;

public class Game{
    public Player player {get; set;}

    
    public void Start(){
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Player player = new Player(name, 0);

        Console.Write("Нажмите Enter, чтобы начать ");
        Console.ReadLine();

        Console.WriteLine("Ваш счёт: {0}", player.money);

        while (true){
            if(askQuestion(player)){
            Console.WriteLine("Ваш счёт: {0}", player.money);

            if (player.money == 1000000){
                Console.WriteLine("Игрок {0}, вы стали победителем!", player.name);
                break;
            }

            continue;                
            } else {
                break;
            }
        }

    }



    bool askQuestion(Player player){
    string json;

    string path = "Q" + Convert.ToString(player.corrAnsNum+1) + "_ser.json";

    using (FileStream fstream = new FileStream(path, FileMode.Open))
    {
        byte[] buffer = new byte[fstream.Length];
        fstream.Read(buffer, 0, buffer.Length);
        json  = Encoding.Default.GetString(buffer);
    }
 
        Question q1 = JsonConvert.DeserializeObject<Question>(json);


        Console.WriteLine(q1.AskedQuestion);

        string[] letters = {"A: ", "B: ", "C: ", "D: "};  

        for (int i = 0; i<4; i++)
        {
            Console.WriteLine(letters[i] + q1.Answers[i]);
        }

        string answer = Console.ReadLine();

        if(answer == q1.Answers[q1.CorrectAnswer]){
            player.corrAnsNum ++;
            player.addMoney();
            return true;
        } else {
            if (player.corrAnsNum == 1){
                Console.WriteLine("Неверно. Игрок {0}, вы ответили правильно на {1} вопрос", player.name, player.corrAnsNum);
            } else if (player.corrAnsNum < 5){
                Console.WriteLine("Неверно. Игрок {0}, вы ответили правильно на {1} вопроса", player.name, player.corrAnsNum);
            } else {
                Console.WriteLine("Неверно. Игрок {0}, вы ответили правильно на {1} вопросов", player.name, player.corrAnsNum);
            }
            return false;
        }


    }
}