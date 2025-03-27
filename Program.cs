using System;
using System.Runtime.InteropServices;

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        this.id = new Random().Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        return uploadedVideos.Count;
    }

    public void addVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {username}");

        foreach(var x in uploadedVideos)
        {
            Console.WriteLine($"Video judul: {x.PrintVideoDetails}");
        }
    }
}

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.id = new Random().Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void increasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID Video    : {id}");
        Console.WriteLine($"Judul Video : {title}");
        Console.WriteLine($"Play Count  : {playCount}");
    }
}

class main
{
    public static void Main(string[] args)
    {
        SayaTubeUser sayaTubeUser = new SayaTubeUser("Hafidz Musyafa Azmi");
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Dune oleh Hafidz Musyafa Azmi");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Dune part 2 oleh Hafidz Musyafa Azmi");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Interstellar oleh Hafidz Musyafa Azmi");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Openheimmer oleh Hafidz Musyafa Azmi");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film The Notebook oleh Hafidz Musyafa Azmi");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Divergent oleh Hafidz Musyafa Azmi");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Stranger Things oleh Hafidz Musyafa Azmi");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Queens Gambit oleh Hafidz Musyafa Azmi");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Enola Holmes oleh Hafidz Musyafa Azmi");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Enola Holmes 2 oleh Hafidz Musyafa Azmi");

        sayaTubeUser.addVideo(video1);
        sayaTubeUser.addVideo(video2);
        sayaTubeUser.addVideo(video3);
        sayaTubeUser.addVideo(video4);
        sayaTubeUser.addVideo(video5);
        sayaTubeUser.addVideo(video6);
        sayaTubeUser.addVideo(video7);
        sayaTubeUser.addVideo(video8);
        sayaTubeUser.addVideo(video9);
        sayaTubeUser.addVideo(video10);

        sayaTubeUser.PrintAllVideoPlayCount();
        
    }
}
