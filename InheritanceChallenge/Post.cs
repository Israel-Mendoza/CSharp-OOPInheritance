using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    public abstract class Post
    {

        // Fields
        protected string _title;
        protected User _sender;
        protected bool _isPublic;

        // Constructor
        public Post(string title, User sender, bool isPublic)
        {
            this.Title = title;
            this.Sender = sender;
            this.IsPublic = isPublic;
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
                Console.WriteLine($"\"{Title}\" submited by {Sender.Name}.");
            else
                Console.WriteLine("Post information unavailable...");
        }
    }
}
