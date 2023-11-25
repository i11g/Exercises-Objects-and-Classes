using System.ComponentModel.DataAnnotations;

namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class Article
    {   
        public Article (string title,string content, string author)
        {
            Title= title;
            Content= content;
            Author= author;
        }
        public string Title { get; set; }
        public string Content { get; set; } 
        public string Author { get; set; } 

        public string ChangeAuthor (string author)
        {
           
            Author = author;
            return author;
        }
        public string ChangeTitle(string title)
        {

            Title = title;
            return title;
        }
    }
}