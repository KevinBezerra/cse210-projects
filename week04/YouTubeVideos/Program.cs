using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("A Great Adventure!", "Josh Ryan", 120);
        video1.AddComment(new Comment("Ryan", "First! Pin it :)"));
        video1.AddComment(new Comment("Sophia", "This was amazing!"));
        video1.AddComment(new Comment("Mark", "Can't wait for part 2!"));

        Video video2 = new Video("Cooking Masterclass", "Emma Lee", 300);
        video2.AddComment(new Comment("Alice", "Tried this recipe, loved it!"));
        video2.AddComment(new Comment("Ben", "Any vegetarian alternatives?"));
        video2.AddComment(new Comment("Chris", "Chef Emma never disappoints!"));

        Video video3 = new Video("The Mystery of the Lost City", "David Smith", 540);
        video3.AddComment(new Comment("Nancy", "This documentary is top-notch!"));
        video3.AddComment(new Comment("Paul", "More history content, please!"));
        video3.AddComment(new Comment("Olivia", "Absolutely fascinating!"));

        Video video4 = new Video("Epic Gaming Moments", "Leo Johnson", 180);
        video4.AddComment(new Comment("Jake", "LOL, that headshot was insane!"));
        video4.AddComment(new Comment("Emma", "What game is this?"));
        video4.AddComment(new Comment("Mason", "Best compilation ever!"));

        Videos videos = new Videos();
        videos.AddVideo(video1);
        videos.AddVideo(video2);
        videos.AddVideo(video3);
        videos.AddVideo(video4);

        videos.Display();

    }
}