using System;
using System.IO;

public class Verse
{
    private string[] _text;
    // verse number is never deleted
    private int _verseNumber = 0;
    private int _wordsRemaining;

    public Verse(string text, int verseNumber)
    {
        _text = text.Split(" ");
        _verseNumber = verseNumber;
        _wordsRemaining = _text.Length;
    }

    // displays the verse
    public void DisplayVerse()
    {
        string displayString = $"{_verseNumber}. ";
        
        foreach(string word in _text){
            displayString += $"{word} ";
        }
        Console.WriteLine(displayString);
    }

    // replaces a word in the verse with a _ for each letter and returns it
    private string ReplaceWord(string word)
    {
        string replaceWord = "";
        foreach(char letter in word){
            replaceWord += "_";
        }

        return replaceWord;
    }

    // 
    public void DeleteRandom()
    {
        // checks to make sure this verse has words remaing to delete
        if (_wordsRemaining > 0)
        {
            // picks a random word until it finds one that hasn't been replaced already
            bool change = false;
            while (change == false)
            {
                Random rd = new Random();
                int randNum = rd.Next(0,_text.Length);

                if (_text[randNum][0] != '_')
                {
                    _text[randNum] = ReplaceWord(_text[randNum]);
                    _wordsRemaining -= 1;
                    change = true;
                }
            }
        }
    }

    // getter for words remaining
    public int VerseWordsRemaining()
    {
        return _wordsRemaining;
    }              
}