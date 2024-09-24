namespace TextBasedRpgProject
{
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
            Encounters.firstEncounter();
        }

        //Start function dummy
        static void Start()
        {
            Console.WriteLine("PlaceHolder Start Text.");
            Console.WriteLine("PlaceHolder Text To Ask Player Name.");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("PlaceHolder Story Info");
            //Dumb Example
            //Console.WriteLine($"PlaceHolder Text To Greet Player " + currentPlayer.name);
            if (currentPlayer.name == "")Console.WriteLine("PlaceHolder Memory Loss Text");else Console.WriteLine($"PlaceHolder Greetings Text To Play {currentPlayer.name}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("PlaceHolder Story Intro");
            Console.WriteLine("PlaceHolder Descriptive Text");


        }
    }
}