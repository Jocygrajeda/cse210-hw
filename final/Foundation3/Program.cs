using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address eventAddress1 = new Address("990 Main St", "Anytown", "CA", "USA");
        Address eventAddress2 = new Address("1209 Flora Ave", "Greenville", "NY", "USA");
        Address eventAddress3 = new Address("123 Nature Blvd", "Corona", "BC", "Mexico");

        // Create events
        Event genericEvent = new Event("Generic Event", "A generic event", DateTime.Now, TimeSpan.FromHours(2), eventAddress1);
        Lecture lectureEvent = new Lecture("Tech Talk", "An informative lecture", DateTime.Now.AddDays(10), TimeSpan.FromHours(1), eventAddress2, "Maria Kim", 100);
        Reception receptionEvent = new Reception("Wedding", "A social reception", DateTime.Now.AddDays(20), TimeSpan.FromHours(3), eventAddress1, "coco_@gmail.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Picnic at the Park", "A casual outdoor gathering", DateTime.Now.AddDays(30), TimeSpan.FromHours(4), eventAddress3, "Sunny with a chance of clouds");

        // Display results
        DisplayEventInformation(genericEvent, "Generic Event");
        DisplayEventInformation(lectureEvent, "Lecture Event");
        DisplayEventInformation(receptionEvent, "Reception Event");
        DisplayEventInformation(outdoorEvent, "Outdoor Gathering Event");
    }

    static void DisplayEventInformation(Event eventInstance, string eventName)
    {
        Console.WriteLine($"{eventName} - Standard Details:");
        Console.WriteLine(eventInstance.GenerateStandardDetails());
        Console.WriteLine();

        Console.WriteLine($"{eventName} - Full Details:");
        Console.WriteLine(eventInstance.GenerateFullDetails());
        Console.WriteLine();

        Console.WriteLine($"{eventName} - Short Description:");
        Console.WriteLine(eventInstance.GenerateShortDescription());
        Console.WriteLine("\n----------------------\n");
    }
}
