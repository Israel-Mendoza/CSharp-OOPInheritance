using System;
using System.Collections.Generic;
using System.Text;

namespace FinalApp
{
    class YouTuber : Creator
    {
        public override void Create()
        {
            if (base.CreativityLevel >= 50 && base.Energy >= 50)
            {
                this.BrainStormVideoIdeas();
                this.CreateScript();
                this.RecordVideo();
                this.EditVideo();
                this.UploadVideo();
            }
            else
                throw new Exception("Cannot produce a video... YouTuber is either out of ideas or is tired...");
        }

        private void BrainStormVideoIdeas()
        {
            base.CreativityLevel -= 15;
            base.Energy -= 10;
            Console.WriteLine("Brain storming video ideas...");
        }

        private void CreateScript()
        {
            base.CreativityLevel -= 10;
            base.Energy -= 5;
            Console.WriteLine("Creating script...");
        }

        private void RecordVideo()
        {
            base.CreativityLevel -= 5;
            base.Energy -= 5;
            Console.WriteLine("Recording video...");
        }

        private void EditVideo()
        {
            base.CreativityLevel -= 5;
            base.Energy -= 5;
            Console.WriteLine("Editing video...");
        }

        private void UploadVideo()
        {
            base.CreativityLevel -= 1;
            base.Energy -= 1;
            Console.WriteLine("Uploading video video...");
        }
    }
}
