using System;

namespace csharp_rps
{
  class Program
  {
    static void Main(string[] args)
    {

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine("Type 'rock', 'paper' or 'scissors'");
        string choice = Console.ReadLine();

        Random random = new Random();

        int randomNumber = random.Next(0, 3);

        string computerChoice = "";
        if (randomNumber == 0)
        {
          computerChoice = "rock";
        }
        else if (randomNumber == 1)
        {
          computerChoice = "paper";
        }
        else if (randomNumber == 2)
        {
          computerChoice = "scissors";
        }

        if (choice == computerChoice)
        {
          Console.WriteLine("Tie!!!!!");
        }
        else if (choice.Equals("rock") && computerChoice.Equals("paper"))
        {
          Console.WriteLine("You choose 'rock.' Computer chooses 'paper,' YOU LOSE!");
        }
        else if (choice.Equals("rock") && computerChoice.Equals("scissors"))
        {
          Console.WriteLine("You choose 'rock.' Computer chooses 'scissors,' YOU WIN!");
        }
        else if (choice.Equals("paper") && computerChoice.Equals("rock"))
        {
          Console.WriteLine("You choose 'paper.' Computer chooses 'rock,' YOU WIN!");
        }
        else if (choice.Equals("paper") && computerChoice.Equals("scissors"))
        {
          Console.WriteLine("You choose 'paper.' Computer chooses 'scissors,' YOU LOSE!");
        }
        else if (choice.Equals("scissors") && computerChoice.Equals("rock"))
        {
          Console.WriteLine("You choose 'scissors.' Computer chooses 'rock,' YOU LOSE!");
        }
        else if (choice.Equals("scissors") && computerChoice.Equals("paper"))
        {
          Console.WriteLine("You choose 'scissors.' Computer chooses 'rock,' YOU WIN!");
        }
      }
    }
  }
}
