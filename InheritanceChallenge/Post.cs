using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    public abstract class Post
    {
        // Static fields
        private static int _postIDNumber = 0;

        // Fields
        protected string _title;
        protected User _sender;
        protected bool _isPublic;
        protected int _postID;

        // Constructor
        public Post(string title, User sender, bool isPublic)
        {
            this.Title = title;
            this.Sender = sender;
            this.IsPublic = isPublic;
            this._postID = this.GetCurrentPostID();
        }
        
        // Properties
        public virtual string Title 
        { 
            get => this._title;
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this._title = value;
                else
                    throw new Exception("Post title must be a non-empty string...");
            } 
        }

        public virtual User Sender { get => this._sender; set => this._sender = value; }

        public virtual bool IsPublic { get => this._isPublic; set => this._isPublic = value; }

        public virtual void DisplayPostBasicInfo()
        {
            if (IsPublic)
                Console.WriteLine($"{PostID}\"{Title}\" submited by {Sender.Name}.");
            else
                Console.WriteLine("Post information unavailable...");
        }

        static public int PostIDNumber { get => Post._postIDNumber; }

        public int PostID 
        { 
            // Returns the PostID of the post instance
            get => this._postID;  
        }

        // Methods
        public abstract void DisplayPost();

        private int GetCurrentPostID()
        {
            // Increases the static PostIDNumber by one and return the new number. To be called by the constructor. 
            Post._postIDNumber++;
            return PostIDNumber;
        }
    }
}
