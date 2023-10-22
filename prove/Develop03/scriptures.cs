using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{
    private Reference reference;
    private string text;
    private List<Word> words;
    private Random random;

    //constructor
    public Scripture(string book, int chapter, int verse, string text)
    {
        this.reference = new Reference(book, chapter, verse);
        this.text = text;
        this.words = InitializeWords(text);
        this.random = new Random();
    }

    //display method
    public void Display()
    {
        Console.WriteLine($"{reference.Book} {reference.Chapter}:{reference.StartVerse}-{reference.EndVerse}");

        foreach (var word in words)
        {
            if (word.IsHidden)
                Console.Write("_ ");
            else
                Console.Write($"{word.Text} ");
        }

        Console.WriteLine();
    }

    //hide a random word
    public void HideRandomWord()
    {
        List<Word> visibleWords = words.FindAll(word => !word.IsHidden);

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }

    public bool AllWordsHidden => words.TrueForAll(word => word.IsHidden);

    // initialize the list of words from the scripture text
    private List<Word> InitializeWords(string text)
    {
        string[] wordArray = text.Split(' ');
        List<Word> wordList = new List<Word>();

        foreach (var word in wordArray)
        {
            wordList.Add(new Word(word));
        }

        return wordList;
    }

    public void ClearConsole()
    {
        Console.Clear();
    }

public static Scripture LoadFromFile(string filePath)
{
    try
    {
        string[] lines = File.ReadAllLines(filePath);

        string book = lines[0];
        int chapter = int.Parse(lines[1]);
        int verse = int.Parse(lines[2]);
        string text = string.Join(" ", lines.Skip(3));

        return new Scripture(book, chapter, verse, text);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading scripture from file: {ex.Message}");
        return null;
    }
}

}
