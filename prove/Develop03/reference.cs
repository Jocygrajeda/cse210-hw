class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    //single verse
    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = verse;
        this.endVerse = verse;
    }

    //multiple verses
    //im not sure if its working
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    // properties for Reference
    public string Book => book;
    public int Chapter => chapter;
    public int StartVerse => startVerse;
    public int EndVerse => endVerse;
}