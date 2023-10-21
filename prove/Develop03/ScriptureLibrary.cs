using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> scriptures;
    private Random random;

    public ScriptureLibrary()
    {
        // Initialize the library with different scriptures
        scriptures = new List<Scripture>
        {
            new Scripture("John", 3, 16, "For God so loved the world..."),
            new Scripture("Matthew", 5, 16, "Let your light so shine before men..."),
            // Add more scriptures as needed
        };

        random = new Random();
    }

    // Get a random scripture from the library
    public Scripture GetRandomScripture()
    {
        int randomIndex = random.Next(scriptures.Count);
        return scriptures[randomIndex];
    }
}
