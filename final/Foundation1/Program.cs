using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //video objects w initial info
        Video video1 = new Video("Go to Japan with me", "Celyne Rodriguez", 3500);
        video1.AddComment("ver_onuca", "great video!");
        video1.AddComment("mels_luna", "what color is your hair??");
        video1.AddComment("prommethius", "thats crazyyy");

        Video video2 = new Video("Python Tutorial", "Kimberly Smith", 2450);
        video2.AddComment("coder312", "best tutorial ever!");
        video2.AddComment("github_newbie_", "very helpful");
        video2.AddComment("johnmin", "I still dont get it :()");

        Video video3 = new Video("Travel Vlog", "Lala00", 1600);
        video3.AddComment("legomin", "how much was the total?");
        video3.AddComment("wrecktart99", "did you need a visa?");
        video3.AddComment("nechochin_xx", ":)");

        List<Video> videoList = new List<Video> { video1, video2, video3 };//create list to store the video objects

        foreach (Video video in videoList)// display info
        {
            video.DisplayInfo();
        }
    }
}
