using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    public class VideoPost : Post
    {
        // Fields
        private string _videoURL;

        // Constructor
        public VideoPost(string title, User sender, bool isPublic, string videoURL) : base(title, sender, isPublic)
        {
            this._videoURL = videoURL;
        }

        // Properties
        public string VideoURL
        {
            get => this._videoURL;
            set
            {
                if (String.IsNullOrEmpty(value))
                    this._videoURL = value;
                else
                    throw new Exception("The video URL must be a valid URL address!");
            }
        }

    }
}
