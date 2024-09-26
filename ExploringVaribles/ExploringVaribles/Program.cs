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
            
        }
    }
}
