using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int[][] NPCs;


            Console.WriteLine("Insert Number of NPCs you want");
            int inputtedNumberOfNPCs = int.Parse(Console.ReadLine());
            x = inputtedNumberOfNPCs;

            NPCs = new int[x][];

            for (int i = 0; i < NPCs.Length; i++)
            {
                Console.WriteLine($"NPC Number {i + 1}:");
                Console.WriteLine("Insert Number of Perks you want in the NPC");
                int numberOfCaracteristics = int.Parse(Console.ReadLine());
                y = numberOfCaracteristics;
                NPCs[i] = new int[y];
                for (int j = 0; j < NPCs[i].Length; j++)
                {
                    Console.WriteLine("What Perk You Want(0 - Stealth, 1 - Combat, 2 - PickLock, 3 - Luck)");
                    int caracteristicIDNumber = int.Parse(Console.ReadLine());
                    NPCs[i][j] = caracteristicIDNumber;
                    switch (caracteristicIDNumber)
                    {
                        case 0:
                            Console.WriteLine(NPCCaracteristics.Stealth);
                            break;
                        case 1:
                            Console.WriteLine(NPCCaracteristics.Combat);
                            Console.WriteLine("You shall win all fights");
                            break;
                        case 2:
                            Console.WriteLine(NPCCaracteristics.Picklock);
                            break;
                        case 3:
                            Console.WriteLine(NPCCaracteristics.Luck);
                            Console.WriteLine("You shall win all fights");
                            break;
                        default:
                            break;
                    }
                    
                    
                    

                }



            }



        }
    }
}
