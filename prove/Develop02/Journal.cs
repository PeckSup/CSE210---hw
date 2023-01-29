using System;

// A journal is a collection of Entries with a name
public class Journal
{
    public string _journalName = "";
    // prepares list for entries
    public List<Entry> _journalEntries = new List<Entry>();

    // displays each entry in the journal
    public void ReadJournal()
    {
            foreach (Entry entry in _journalEntries)
            {
                entry.DispayEntry();
            }
    }

    // saves the journal as a file
    public void SaveJournal()
    {
        using (StreamWriter openFile = new StreamWriter(_journalName))
        {
            foreach (Entry entry in _journalEntries)
            {
                // each journal is written on 1 line with "|" dividing the Entry variables
                openFile.Write($"{entry._entryDate}|{entry._givenPrompt}|");
                openFile.WriteLine($"{entry._response}");
            }
        }
    }

    // Opens and decifers a journal file
    public void LoadJournal()
    {
        string[] contents = System.IO.File.ReadAllLines(_journalName);

        foreach (string line in contents)
        {
            // each line in the file needs to be seperated
            // each line is an Entry, with "|" dividing the Entry variables
            string[] journalEntry = line.Split("|");

            Entry entry = new Entry();
            entry._entryDate = journalEntry[0];
            entry._givenPrompt = journalEntry[1];
            entry._response = journalEntry[2];

            _journalEntries.Add(entry);
        }
    }
}