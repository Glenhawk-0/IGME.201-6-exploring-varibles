namespace ExploringVaribles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //varibles
            string heroFirstName = "Lennon";
            string heroLastName =   "Hare";
            string heroFullName = heroFirstName +" "+ heroLastName;
            string villianTitle = "Lord of Server Bug's";
            string minionTitle = "Bug's";
            string villianName = "Craig";
            string minion1Name = "401";
            string minion2Name = "402";


            //stats
            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;
           

            //begin Code Instructions

            Console.WriteLine("Behold my fellow code's, our saviour has arrived. " + "our hero's name is " + heroFullName + "!!!");

            Console.WriteLine(heroFullName + "'s arch nemesis is " + villianName + " the " + villianTitle);
            Console.WriteLine(villianName + " the " + villianTitle + " commands the " + minionTitle + " such as the monstrous " + minion1Name + " and the terrible " + minion2Name + "!");

            //the fight
            Console.WriteLine("the fight shall commence");
            Console.WriteLine("hero's health: " + heroHealth);
            Console.WriteLine("boss's health: " + bossHealth);
            Console.WriteLine("minion 1's health: " + minion1Health);
            Console.WriteLine("minion 2's health: " + minion2Health);

            //fight time  
            Console.WriteLine(villianName + " attacks " + heroFullName);
            Console.WriteLine(heroFullName + " takes " + bossStrength + " damage ");

            //current health, subtracted by attacker strength
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health") ;

            Console.WriteLine("the minions attack " + heroFullName);
            Console.WriteLine("together " + minion1Name + " and " + minion2Name + " deal " + (minionStrength + minionStrength) + " damage to " + heroFullName );
            heroHealth = heroHealth - (minionStrength + minionStrength);
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health");
            Console.WriteLine("wow, this is taking a while, lets give lennon some help, lennon now deals double damage" );
            Console.WriteLine(heroFullName + " attacks " + villianName + " and " + minion1Name + " and " + minion2Name);
            Console.WriteLine(villianName + " and " + minion1Name + " and " + minion2Name + " take " + (heroStrength + heroStrength) + " Damage!!!");

            Console.WriteLine(villianName + " now has " + (bossHealth - (heroStrength*2) ) + " health");
            Console.WriteLine(minion1Name + " now has " + (minion1Health - (heroStrength * 2)) + " health");
            Console.WriteLine(minion2Name + " now has " + (minion2Health - (heroStrength * 2)) + " health");



        }   
    }
}
