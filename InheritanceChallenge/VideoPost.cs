using System;
using System.Threading;

namespace InheritanceChallenge
{
    public class VideoPost : Post
    {
        // Fields
        private string _videoURL;
        private int _lengthInSeconds;
        private bool _isPlaying = false;
        private int _currentPlayedTime = 0;
        private Timer myTimer;

        // Constructor
        public VideoPost(string title, User sender, bool isPublic, string videoURL, int lengthInSeconds) : base(title, sender, isPublic)
        {
            this.VideoURL = videoURL;
            this.VideoLengthInSecs = lengthInSeconds;
        }

        // Properties
        public string VideoURL
        {
            get => this._videoURL;
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this._videoURL = value;
                else
                    throw new Exception("The video URL must be a valid URL address!");
            }
        }

        public int VideoLengthInSecs
        {
            get => this._lengthInSeconds;
            set
            {
                if (value > 0)
                    this._lengthInSeconds = value;
                else
                    throw new Exception("Video length must be at least 1 second...");
            }
        }

        public bool IsPlaying { get => this._isPlaying; set => this._isPlaying = value; }
        
        private int CurrentPlayedTimeInSecs { get => this._currentPlayedTime; set => this._currentPlayedTime = value; }

        // Methods
        public override void DisplayPost()
        {
            Console.WriteLine($"Playing video hosted in {VideoURL}");
        }

        public void PlayVideo()
        {
            if (!IsPlaying)
            {
                IsPlaying = true;
                Console.WriteLine($"Playing {Title}");
                myTimer = new Timer(TimerCallback, null, 0, 1000);
            }   
        }

        private void TimerCallback(Object obj)
        {
            if (CurrentPlayedTimeInSecs < VideoLengthInSecs)
            {
                CurrentPlayedTimeInSecs++;
                Console.WriteLine($"Video playing at {CurrentPlayedTimeInSecs}");
                GC.Collect();
            }
            else
                StopVideo();
        }

        public void StopVideo()
        {
            if (IsPlaying)
            {
                Console.WriteLine($"Video stopped at {CurrentPlayedTimeInSecs}");
                IsPlaying = false;
                CurrentPlayedTimeInSecs = 0;
                myTimer.Dispose();
            }
            else
                Console.WriteLine("Video is not being played...");
        }
    }
}
