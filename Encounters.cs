using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRpgProject
{
    class Encounters
    {
        static Random rand = new Random();
        //Encounter Generic




        //Ecounters
        public static void firstEncounter()
        {
            Console.WriteLine($"You get spotted by a Rogue!");
            Console.ReadKey();
            combat(false, "Human Rogue",1,4);

        }
        //Ecounter Tools
        public static void combat(bool random, string name, int power, int health) 
        {
            string n = "";
            int p = 0;
            int h = 0;

            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while(h>0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" +h);
                Console.WriteLine("===================");
                Console.WriteLine("|(A)ttack (D)efend|");
                Console.WriteLine("|(R)un    (H)eal  |");
                Console.WriteLine("===================");
                Console.WriteLine($"Potions: {Program.currentPlayer.potions} Health: {+Program.currentPlayer.health}");
                string? input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower()=="attack") 
                { 
                    //Attack
                    Console.WriteLine($"{n} hits you back");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0) damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1,4);
                    Console.WriteLine($"You lose {damage} health and deal {attack} damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine($"The enemy {n} attacks into player defensive stance");
                    int damage = (p/4) - Program.currentPlayer.armorValue;
                    if (damage < 0) damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue)/2;
                    Console.WriteLine($"You lose {damage} health and you deal {attack} damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    if(rand.Next(0, 2) == 0) 
                    {
                        Console.WriteLine("You get hit trying to run away");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)damage = 0;
                        Console.WriteLine($"You Lose {damage} health and are unable to escape.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You run away at full speed and manage to escape... for now.");
                        Console.ReadKey();
                        //go to store
                    }
                }
                if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                    if (Program.currentPlayer.potions == 0)
                    {
                        Console.WriteLine("No potions left");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0) damage = 0;
                        Console.WriteLine($"You get hit by {n} losing {damage} health");
                    }
                    else
                    {
                        int potionV = 5;
                        Console.WriteLine($"You heal for {potionV} health");
                        Program.currentPlayer.health += potionV;
                        int damage = (p/2) - Program.currentPlayer.armorValue;
                        if(damage < 0)damage = 0;
                        Console.WriteLine($"You lose {damage} health");
                    }
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}
