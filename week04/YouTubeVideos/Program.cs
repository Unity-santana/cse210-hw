class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video();
        video1._title = "Learn C# Basics";
        video1._author = "CodeMaster";
        video1._length = 600;

        video1._comments.Add(new Comment("Alice", "Great tutorial!"));
        video1._comments.Add(new Comment("Bob", "Very helpful."));
        video1._comments.Add(new Comment("Charlie", "I learned a lot."));

        Video video2 = new Video();
        video2._title = "OOP Made Easy";
        video2._author = "DevWorld";
        video2._length = 800;

        video2._comments.Add(new Comment("David", "Nice explanation!"));
        video2._comments.Add(new Comment("Eve", "Loved this video."));
        video2._comments.Add(new Comment("Frank", "Very clear teaching."));

        Video video3 = new Video();
        video3._title = "Advanced C# Concepts";
        video3._author = "TechGuru";
        video3._length = 1200;

        video3._comments.Add(new Comment("Grace", "This is deep!"));
        video3._comments.Add(new Comment("Henry", "Challenging but good."));
        video3._comments.Add(new Comment("Ivy", "Well explained."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display videos
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length (seconds): " + video._length);
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine(comment._name + ": " + comment._text);
            }

            Console.WriteLine("---------------------------");
        }
    }
}