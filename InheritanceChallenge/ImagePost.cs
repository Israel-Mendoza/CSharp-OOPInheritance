using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    public class ImagePost : Post
    {

        // Fields
        private string _title;
        private bool _isPublic;
        private User _sender;
        private string _imageURL;

        // Constructor
        public ImagePost(string title, bool isPublic, User sender, string imageURL)
        {
            this.Title = title;
            this.IsPublic = isPublic;
            this.Sender = sender;
            this.ImageURL = imageURL;
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

        public override bool IsPublic { get => this._isPublic; set => this._isPublic = value; }

        public override User Sender { get => this._sender; set => this._sender = value; }

        public string ImageURL { get => this._imageURL; set => this._imageURL = value; }


    }
}
