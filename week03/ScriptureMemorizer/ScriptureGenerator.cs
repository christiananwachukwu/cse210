using System;
using System.Collections.Generic;

public class ScriptureGenerator
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureGenerator()
    {
        _random = new Random();
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding."),
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son..."),
            new Scripture(new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Moroni", 10, 4, 5),
                "And when ye shall receive these things, I would exhort you that ye would ask God... he will manifest the truth of it unto you, by the power of the Holy Ghost."),
            new Scripture(new Reference("Alma", 37, 6),
                "By small and simple things are great things brought to pass..."),
            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("2 Nephi", 2, 27),
                "Wherefore, men are free according to the flesh... they are free to choose liberty and eternal life..."),
            new Scripture(new Reference("D&C", 88, 118),
                "Seek ye out of the best books words of wisdom; seek learning, even by study and also by faith."),
            new Scripture(new Reference("D&C", 121, 7, 8),
                "My son, peace be unto thy soul; thine adversity and thine afflictions shall be but a small moment..."),
            new Scripture(new Reference("D&C", 18, 10),
                "Remember the worth of souls is great in the sight of God.")
        };
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}