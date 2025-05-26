using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("How to make Egusi Soup", "Chef Christy", 300);
        video1.AddComment(new Comment("Chioma", "Looks delicious!"));
        video1.AddComment(new Comment("Chizzy", "I'm definitely trying this out over the weekend."));
        video1.AddComment(new Comment("Jennifer", "Chef Christy, whatever happens with inviting us to dinner? I go chop oo!"));
        video1.AddComment(new Comment("Ayo", "Nice one, keep dishing us with contents."));
        videos.Add(video1);

        Video video2 = new Video("How to make a good lesson plan", "Teacher Ebube", 450);
        video2.AddComment(new Comment("Angela", "Thanks for making teaching so easy."));
        video2.AddComment(new Comment("Amaka", "Now I see where I've been getting it wrong all along. Thanks teacher Ebube."));
        video2.AddComment(new Comment("Emmanuel", "This is awesome. Well done master!"));
        videos.Add(video2);

        Video video3 = new Video("Spiritual Health", "Elder Graham Joyful", 600);
        video3.AddComment(new Comment("Ride on sir!", "Big Ben"));
        video3.AddComment(new Comment("I'll follow Jesus till eternity.", "Richard"));
        video3.AddComment(new Comment("Take me back to my Father!", "Adaugo"));
        videos.Add(video3);

        Video video4 = new Video("DIY: Homemade Soap", "Amarachi", 750);
        video4.AddComment(new Comment("What perfume did you use?", "James"));
        video4.AddComment(new Comment("How much will it cost to ge the whole ingredients?", "Esther"));
        video4.AddComment(new Comment("I'm trying this right away. Thanks for sharing!", "Pat"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine($"Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}