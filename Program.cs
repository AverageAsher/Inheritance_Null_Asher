namespace Inheritance_Null_Asher
{
    using System;

    // Abstract class Game
    abstract class Game
    {
        // Automatic properties
        public string ESRB { get; }
        public string Title { get; }

        // Constructor
        public Game(string esrb, string title)
        {
            ESRB = esrb;
            Title = title;
        }

        // Method to play the game
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting");
        }

        // Abstract method to describe the game
        public abstract string Describe();
    }

    // Inheriting class from Game
    class FPS : Game
    {
        // Constructor inheriting from base class
        public FPS(string esrb, string title) : base(esrb, title)
        {
        }

        // Overriding Describe method
        public override string Describe()
        {
            return $"This is a first-person shooter game titled {Title} with ESRB rating {ESRB}.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating FPS object
            FPS fpsGame = new FPS("Mature", "Call of Duty");

            // Calling Describe method
            Console.WriteLine(fpsGame.Describe());

            // Calling PlayGame method
            fpsGame.PlayGame();
        }
    }
}