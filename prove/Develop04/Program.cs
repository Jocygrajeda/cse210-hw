using System;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;

        while (menu != 4)
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════╗");
            Console.WriteLine("║      Menu Options        ║");
            Console.WriteLine("╠══════════════════════════╣");
            Console.WriteLine("║  1. breathing Activity   ║");
            Console.WriteLine("║  2. reflection Activity  ║");
            Console.WriteLine("║  3. listing Activity     ║");
            Console.WriteLine("║  4. Quit                 ║");
            Console.WriteLine("╚══════════════════════════╝");
            Console.Write("Select a choice from the menu: ");
            
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                Breathing breathingActivity = new Breathing(10, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing", 5, 5, "", 5,5);
                breathingActivity.StartBreathingActivity();
            }

            else if (menu == 2)
            {
                Reflection Reflect = new Reflection(10, "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection", 5, 5, "");
                Reflect.StartReflectionActivity();
            }

            else if (menu == 3)
            {
                Listing listingActivity = new Listing(10, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing", 5, 5, "");
                listingActivity.GetRandomList();
            }

            else if (menu == 4)
            {
                Console.Write("Later...");
            }
        }
    }
}
