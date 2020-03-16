using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    public class TextPost : Post
    {
        
        // Fields
        private string _postContents;

        // Constructor
        public TextPost (string title, User sender, bool isPublic, string postContents) : base(title, sender, isPublic)
        {
            this.PostContents = postContents;
        }

        // Properties
        public string PostContents 
        { 
            get => this._postContents;
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this._postContents = value;
                else
                    throw new Exception("Text post must contain a non-empty string in its contents.");
            }
        }

        public override void DisplayPost()
        {
            Console.WriteLine(PostContents);
        }
    }
}
