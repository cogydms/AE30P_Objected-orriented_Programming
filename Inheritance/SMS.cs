namespace Module3.Classes;

public class SMS: Message{
    
    public SMS(string To, string Content){
        this.To = To;
        this.Content = Content;
    }
    public override void Send(){
        Console.WriteLine("==== SMS ====");
        base.Send();
        Console.WriteLine("===============");
    }
}