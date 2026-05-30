using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Bake Pupusas", "ChefMaria", 425);
        video1.AddComment(new Comment("Carlos", "These look amazing! Can't wait to try."));
        video1.AddComment(new Comment("Sofia", "My grandma made these every Sunday."));
        video1.AddComment(new Comment("Luis", "What kind of cheese do you recommend?"));
        videos.Add(video1);

        Video video2 = new Video("Learn C# in 10 Minutes", "CodeMaster", 612);
        video2.AddComment(new Comment("Anna", "Finally a clear tutorial on classes!"));
        video2.AddComment(new Comment("Mike", "Helped me pass my exam, thanks!"));
        video2.AddComment(new Comment("Jenny", "Could you make one about LINQ?"));
        video2.AddComment(new Comment("Pedro", "Great pacing and explanations."));
        videos.Add(video2);

        Video video3 = new Video("Top 5 Hiking Trails in Utah", "OutdoorLife", 845);
        video3.AddComment(new Comment("Brian", "Just hiked Angels Landing last week!"));
        video3.AddComment(new Comment("Emma", "Adding all of these to my bucket list."));
        video3.AddComment(new Comment("Tom", "Beautiful drone shots."));
        videos.Add(video3);

        Video video4 = new Video("Beginner Guitar Lesson", "MusicSchool", 720);
        video4.AddComment(new Comment("Rachel", "Best guitar tutorial I've watched."));
        video4.AddComment(new Comment("Diego", "My fingers hurt but I love it."));
        video4.AddComment(new Comment("Lily", "Can you teach a song next?"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
