using System;

public class Job
{
    public string _company = "";
    public string _position = "";
    public int _startYear = 1;
    public int _endYear = 1;

    public void DisplayJob()
    {
        Console.WriteLine($"{_position} ({_company}) {_startYear} - {_endYear}");
    }
    
}