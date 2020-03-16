using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    public class VideoPost : Post
    {
        // Fields
        private string _title;
        private User _sender;
        private bool _isPublic;
        private string _videoURL;

        // Constructor
        public VideoPost(string title, bool isPublic, User sender, string videoURL)
        {
            this.Title = title;
            this.IsPublic = isPublic;
            this.Sender = sender;
            this.VideoURL = videoURL;
        }

        // Properties
        public override string Title
        {
            get => this._title;
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this._title = value;
                else
                    throw new Exception("The Title property must be a non-empty string...");
            }
        }

        public override User Sender { get => this._sender; set => this._sender = value; }

        public override bool IsPublic { get => this._isPublic; set => this._isPublic = value; }

        public string VideoURL { get => this._videoURL; set => this._videoURL = value; }

    }
}
