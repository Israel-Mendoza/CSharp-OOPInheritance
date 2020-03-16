using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    public class User
    {
        // Fields
        private string _name;
        private int _age;
        private string _email;
        private List<Post> _userPosts = new List<Post>();

        // Constructor
        public User(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        
        // Properties
        public string Name 
        { 
            get => this._name;
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this._name = value;
                else
                    throw new Exception("User's name must be a non-empty string...");
            } 
        }
        public int Age
        {
            get => this._age;
            set
            {
                if (value > 18)
                    this._age = value;
                else
                    throw new Exception("User must be over 18 to use this application...");
            }
        }
        public string Email
        {
            get => this._email;
            set
            {
                if (!String.IsNullOrEmpty(value) && value.Contains('@'))
                    this._email = value;
                else
                    throw new Exception("Email field must be a valid email address...");
            }
        }

        public List<Post> UserPosts { get => this._userPosts; }

        // Methods
        public TextPost CreateTextPost(string postTitle, bool isPostPublic, string postContents)
        {
            TextPost tempPost = new TextPost(postTitle, this, isPostPublic, postContents);
            this._userPosts.Add(tempPost);
            return tempPost;
        }

        public ImagePost CreateImagePost(string postTitle, bool isPostPublic, string imageURL)
        {
            ImagePost tempPost = new ImagePost(postTitle, isPostPublic, this, imageURL);
            this._userPosts.Add(tempPost);
            return tempPost;
        }

        public VideoPost CreateVideoPost(string postTitle, bool isPostPublic, string videoURL)
        {
            VideoPost tempPost = new VideoPost(postTitle, isPostPublic, this, videoURL);
            this._userPosts.Add(tempPost);
            return tempPost;
        }
    }
}
