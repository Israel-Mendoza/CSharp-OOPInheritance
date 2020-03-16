using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    public class TextPost : Post
    {
        
        // Fields
        private string _title;
        private User _sender;
        private bool _isPublic;
        private string _postContents;

        // Constructor
        public TextPost (string title, User sender, bool isPublic, string postContents)
        {
            this.Title = title;
            this.Sender = sender;
            this.IsPublic = isPublic;
            this.PostContents = postContents;
        }

        // Properties
        public override string Title 
        { 
            get => this._title;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this._title = value;
                }
                else
                    throw new Exception("The Title property must be a non-empty string...");
            }
        }

        public override User Sender { get => this._sender; set => this._sender = value; }

        public override bool IsPublic { get => this._isPublic; set => this._isPublic = value; }

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
    }
}
