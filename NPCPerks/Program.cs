using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            int stealthPerk = (int)NPCCaracteristics.Stealth;
            int combatPerk = (int)NPCCaracteristics.Combat;
            int pickLockPerk = (int)NPCCaracteristics.Picklock;
            int luckPerk = (int)NPCCaracteristics.Luck;

            int x,y;
            int[][] NPCs;
            
            
            Console.WriteLine("Insert Number of NPCs you want");
            int inputtedNumberOfNPCs = int.Parse(Console.ReadLine());
            x = inputtedNumberOfNPCs;
            
            NPCs = new int[x][];
            
            for( int i = 0; i<NPCs.Length;i++)
            {
                Console.WriteLine("Insert Number of Perks you want in the NPC");
                int numberOfCaracteristics = int.Parse(Console.ReadLine());
                y = numberOfCaracteristics;
                NPCs[i] = new int[y];
                for(int j = 0; j<NPCs[i].Length;j++)
                {
                    Console.WriteLine("What Perk You Want: ");
                    int caracteristicIDNumber = int.Parse(Console.ReadLine());
                    NPCs[i][j] = caracteristicIDNumber;
                    
                    Console.WriteLine(NPCs[i][j]);
                }
                
                
                
            }
            


        }
    }
}
