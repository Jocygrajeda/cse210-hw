using System;

class Program
{
    static void Main(string[] args)
    {
         int input = 0;
            while (input != 4)
            {            
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");
                input = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                if (input != 4)
                {
                
                
                    if (input == 1)
                    {
                        BreathingActivity breath = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                        breath.StartMessage();
                        breath.InAndOutLoop();

                        Thread.Sleep(2000);

                        Console.WriteLine();
                        breath.EndMessage();
                        Console.Clear();
                    }
                    else if (input == 2)
                    {
                        ReflectingActivity reflect = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                        reflect.StartMessage();
                        reflect.GetReflectionPrompt();
                        reflect.GetReflectionQuestion();
                        Console.WriteLine();
                        reflect.EndMessage();
                        Console.Clear();
                    }
                    else if (input == 3)
                    {
                        ListingActivity list = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                        list.StartMessage();
                        list.GetListingPrompt();
                        list.RecordListing();
                        Console.WriteLine();
                        list.EndMessage();
                        Console.Clear();
                    }

                }
            }



    }
}