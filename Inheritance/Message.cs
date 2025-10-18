namespace Module3.Classes;

public class Message{

    public virtual string To {get; set;}
    public string Content {get; set;}

    public virtual void Send(){
        Console.WriteLine($"To : {To}");
        Console.WriteLine($"Content: {Content}");
    }
}