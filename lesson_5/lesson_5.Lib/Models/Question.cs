namespace Models;


[Serializable]
public class Question{
    public string AskedQuestion{get; set;}
    public int CorrectAnswer{get; set;}
    public string[] Answers{get; set;}

    public Question(string AskedQuestion, int CorrectAnswer, string[] Answers){
        this.AskedQuestion = AskedQuestion;
        this.CorrectAnswer = CorrectAnswer;
        this.Answers = Answers;
    }
}