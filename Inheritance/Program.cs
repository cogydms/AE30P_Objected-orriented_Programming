using Module3.Classes;

Console.WriteLine("Do you want to send Message?");
Console.Write("1) Email  2) SMS  ");
string num = Console.ReadLine();

if (num == "1"){
    Email E1 = new Email("Subject", "From", "");

    Console.WriteLine("Enter recipient email (press 0 when done): ");
    string input;
    while ((input = Console.ReadLine()) != "0"){
        E1.AddRecipient(input);
    }

    Console.WriteLine("Enter email subject: ");
    E1.Subject = Console.ReadLine();
    Console.WriteLine("Enter sender's name: ");
    E1.From = Console.ReadLine();
    Console.WriteLine("Enter email content: ");
    E1.Content = Console.ReadLine();

    E1.Send();

}
else if (num == "2"){
    SMS S1 = new SMS("", "");
    Console.WriteLine("Enter the phone number: ");
    S1.To = Console.ReadLine();
    Console.WriteLine("Enter content: ");
    S1.Content = Console.ReadLine();

    S1.Send();

}
else {
    Console.WriteLine("Wrong number...");
}

/*
Email E1 = new Email("Submission of Required Documents","Hyoeun", "Hello ~");
E1.AddRecipient("h_chae@utb.cz");
E1.AddRecipient("hyoeunc@utb.cz");

E1.Send();

SMS S1 = new SMS("+420 773-104-999", "Nice to meet you :)");
S1.Send();
*/