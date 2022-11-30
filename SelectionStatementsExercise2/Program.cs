using System.ComponentModel;
using System.Net.Http.Headers;

//Exercise 2

//Fork and Clone the repository - Selection Statement Exercise 2 to your local computer.
//Instructions for forking and cloning a project can be found HERE.

//Create a switch/case statement:
//Inside the scope of your Main() method
// Ask the user for their favorite school subject. 
//Store their answer in a variable
//Pass the variable as the expression in a switch statement.
//Create 5 different cases for different subjects.  Each case will print the subject chosen and a custom message of your choosing.
//Create a default case to handle any case not handled.

//Save and push your work up to your repository





namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "History":
                    Console.WriteLine("History? Never heard of it. Tha's not my favorite subject. Guess again.");
                    break;
                case "Science":
                    Console.WriteLine("Science? Never heard of it. Tha's not my favorite subject. Guess again.");
                    break;
                case "Math":
                    Console.WriteLine("Math? Never heard of it. Tha's not my favorite subject. Guess again.");
                    break;
                case "Literature":
                    Console.WriteLine("Literature? Never heard of it. Tha's not my favorite subject. Guess again.");
                    break;
                case "Music":
                    Console.WriteLine("Music? Never heard of it. Tha's not my favorite subject. Guess again.");
                    break;
                default:
                    Console.WriteLine("That's not a real subject");
                    break;
            }
        }
    }
}