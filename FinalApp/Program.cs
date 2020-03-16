using System;
using System.Collections.Generic;

namespace FinalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator youtuber = new YouTuber();
            Creator programmer = new Programmer();

            List<Creator> someCreators = new List<Creator>() { youtuber, programmer };

            foreach (var creator in someCreators)
            {
                Console.WriteLine($"****************{creator.GetType().Name}****************");
                creator.Create();
                Console.WriteLine();
            }
        }
    }
}
