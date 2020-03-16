using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    public class ImagePost : Post
    {

        // Fields
        private string _imageURL;

        // Constructor
        public ImagePost(string title, User sender, bool isPublic, string imageURL) : base(title, sender, isPublic)
        {
            this.ImageURL = imageURL;
        }

        // Properties
        public string ImageURL
        {
            get => this._imageURL;
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this._imageURL = value;
                else
                    throw new Exception("The image URL must be a valid URL address!");
            }
        }

        public override void DisplayPost()
        {
            Console.WriteLine($"Displaying image hosted in {ImageURL}");
        }
    }
}
