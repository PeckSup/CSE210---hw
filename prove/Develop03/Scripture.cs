using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Verse> _verses = new List<Verse>();
    // The reference is displayed seperately and will never be deleted
    private string _reference;

    public Scripture(string reference)
    {
        _reference = reference;
    }

    // setter for adding verses
    public void AddVerse(Verse addedVerse)
    {
        _verses.Add(addedVerse);
    }

    // displayes the reference, then each verse in new lines each
    public void DisplayScripture()
    {
        Console.WriteLine(_reference);
        foreach (Verse verse in _verses)
        {
            verse.DisplayVerse();
        }
    }

    // deletes 1 word twice from each verse
    public void DeleteWords()
    {
        foreach (Verse verse in _verses)
        {
            verse.DeleteRandom();
            verse.DeleteRandom();
        }
    }

    // add together the remainging words in each verse and return the sum
    public int ScriptureWordsRemaining()
    {
        int numberOfWords = 0;
        foreach (Verse verse in _verses)
        { 
            numberOfWords += verse.VerseWordsRemaining();
        }
        return numberOfWords;
    }

}