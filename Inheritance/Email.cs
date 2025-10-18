namespace Module3.Classes;

public class Email: Message{

    public new List<string> To { get; set; }
    public string Subject{get; set;}
    public string From{get; set;}

    public Email(string Subject, string From, string Content){ //Constructor
        this.To = new List<string>();
        this.Subject = Subject;
        this.From = From;
        this.Content = Content;        
    }
    public void AddRecipient(string address){
        To.Add(address);
    }
    public override void Send(){

        Console.WriteLine("==== EMAIL ====");
        Console.WriteLine($"From: {From}");
        Console.Write("To: ");
        foreach (var recipient in To){
            Console.Write($"{recipient}  "); //Console.WriteLine(string.Join(", ", To));
        }
        Console.WriteLine($"\n\nSubject: {Subject}");
        Console.WriteLine("------------------");
        Console.WriteLine($"{Content}");
        Console.WriteLine("===============");
    }
}