using System;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();
            
            Post post = new Post();
            post.Text = postText;
            post.ShowPost();
        }
    }

    class Post
    {
        private string _text;
        
        public string Text 
        {
            get { return _text; }
            set { _text = value; }
        }

        public Post()
        {
            Console.WriteLine("New post");
        }

        public void ShowPost()
        {
            Console.WriteLine(_text);
        }
    }
}
