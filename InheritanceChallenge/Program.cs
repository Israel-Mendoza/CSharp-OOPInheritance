using System;

namespace InheritanceChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            User myAccount = new User("Israel Mendoza", 27, "xander_irsl@hotmail.com");

            myAccount.CreateTextPost("My First Post", true, "Hello, everyone, this is my first post in ChatoBook!!!");
            myAccount.CreateImagePost("My new phone!", true, "myserver.com/my-images/photo0001");
            myAccount.CreateVideoPost("Me, playing the piano", true, "myserver.com/my-images/vid0001");
            myAccount.CreateImagePost("My dickpic!", false, "myserver.com/my-images/photo0001");

            foreach (var p in myAccount.UserPosts)
            {
                p.DisplayPostBasicInfo();
            }
        }
    }
}
