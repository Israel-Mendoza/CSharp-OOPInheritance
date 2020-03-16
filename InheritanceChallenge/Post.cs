using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    public abstract class Post
    {
        
        public abstract string Title { get; set; }
        public abstract User Sender { get; set; }
        public abstract bool IsPublic { get; set; }

        public virtual void DisplayPostBasicInfo()
        {
            if (IsPublic)
                Console.WriteLine($"\"{Title}\" submited by {Sender.Name}");
            else
                Console.WriteLine("Post information unavailable...");
        }
    }
}
