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

            int inputtedNumberOfNPCs = int.Parse(Console.ReadLine());

            int[] NPCs = new int[inputtedNumberOfNPCs];
            int[] npcCaracteristics = new int[inputtedNumberOfNPCs];
            foreach (int a in NPCs)
            {
                int inputtedCaracteristic = int.Parse((Console.ReadLine()));
                npcCaracteristics[a] = inputtedCaracteristic;
                Console.WriteLine(npcCaracteristics[a]);
                switch (inputtedCaracteristic)
                {
                    case 0:
                        Console.WriteLine(stealthPerk);
                        break;
                    case 1:
                        Console.WriteLine(combatPerk);
                        break;
                    case 2:
                        Console.WriteLine(pickLockPerk);
                        break;
                    case 3:
                        Console.WriteLine(luckPerk);
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

            }



        }
    }
}
