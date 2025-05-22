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
            Console.WriteLine("You wake up with your eyes hazed over. Your head is pounding...");
            Console.WriteLine("Someone speaks to you from the shadows...");
            Console.WriteLine("*THE SHADOW*: What is your name?");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You stare at the shadows waiting a response...");
            if (currentPlayer.name == "")
                Console.WriteLine("*THE SHADOW*: You either don't remember or you are terified... Either way, be safe on your adventures... We will need you later.");
            else Console.WriteLine($"*THE SHADOW*: Nice to meet you {currentPlayer.name}. Please be safe, we will need you later...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("*NARRATOR*: You have awoken in a cell. You have no clue where you are at or why. You stand up trying to understand.");
            Console.WriteLine("The cell is damp and cold... You shrivel up in your coat to get warm.");
            Console.WriteLine("You walk toward the cell door... its unlocked... You open the door and are faced with a guard.");
        }
    }
}