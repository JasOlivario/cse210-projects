using System.Security.Cryptography;

public class Reference
{
    private string _book;

    private int _chapter;

    private int _verse;

    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }


    public string ToString()
    {
        return $"{_book} {_chapter}: {_verse}";
    }
}