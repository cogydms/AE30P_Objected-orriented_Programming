using System;

public class DiceGame{

    static void Main(){
        while(true){
            Random rand = new Random();
            int num1 = rand.Next(1,7);
            int num2 = rand.Next(1,7);
            Console.WriteLine("Your Dice Result: "+ num1);
            Console.WriteLine("Computer's Dice Result: "+ num2);

            if(num1 > num2){
                Console.WriteLine("You are the Winner!");
                break;
            }
            else if(num1 < num2){
                Console.WriteLine("You lose..");
                break;
            }
            else{
                Console.WriteLine("Draw! Rolling again");
            }
        }
    }
}