using System;
using System.Diagnostics;
using System.Threading;

namespace InheritanceChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            User myAccount = new User("Israel Mendoza", 27, "xander_irsl@hotmail.com");

            myAccount.CreateTextPost("My First Post", true, "Hello, everyone, this is my first post in ChatoBook!!!");
            myAccount.CreateImagePost("My new phone!", true, "myserver.com/my-images/photo0001");
            myAccount.CreateVideoPost("Me, playing the piano", true, "myserver.com/my-images/vid0001", 190);
            myAccount.CreateImagePost("My dickpic!", false, "myserver.com/my-images/photo0001");
            myAccount.CreateImagePost("I bought a new laptop", true, "myserver.com/my-images/photo0002");

            /*foreach (var p in myAccount.UserPosts)
            {
                p.DisplayPostBasicInfo();
            }*/

            VideoPost randomVideo = new VideoPost("Random fall", myAccount, true, "vimeo.com/fucking-shit", 5);

            PlayAndTimeRandomVideo(randomVideo);
            
        }

        public static void PlayRandomVideo(User anAccount)
        {
            Console.WriteLine("\nPlaying a video: ");
            Stopwatch myTimer = new Stopwatch();
            myTimer.Start();
            anAccount.UserPosts[2].DisplayPost();
            Console.Write("Press any key to stop playing the video...");
            Console.ReadKey();
            myTimer.Stop();
            Console.WriteLine($"You stopped the video at {myTimer.Elapsed}");
        }

        public static void PlayAndTimeRandomVideo(VideoPost aVideoPost)
        {
            Console.WriteLine("\nPlaying a video: ");
            aVideoPost.PlayVideo();
            Console.WriteLine("Press any key to stop playing...");
            Console.ReadKey();
            aVideoPost.StopVideo();
        }
    }
}
