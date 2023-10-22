class Word
{
    private string text;
    private bool isHidden;

    //constructor
    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    // get the text of the word
    public string Text => text;

    //check if the word is hidden
    public bool IsHidden => isHidden;

    //hide the word
    public void Hide()
    {
        isHidden = true;
    }
}