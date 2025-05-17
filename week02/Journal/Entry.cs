using System;

public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public string Mood { get; set; } // mood tracking

    public Entry(string date, string promptText, string entryText, string mood)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
        Mood = mood;
    }

    public string GetDisplay()
    {
        return $"Date: {Date}\nPrompt: {PromptText}\nMood: {Mood}\nResponse: {EntryText}\n";
    }

    public string ToFileFormat()
    {
        return $"{Date}|{PromptText}|{EntryText}|{Mood}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        string mood = parts.Length > 3 ? parts[3] : "N/A";
        return new Entry(parts[0], parts[1], parts[2], mood);
    }
}