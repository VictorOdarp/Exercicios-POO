using ExercicioStringBuilder.Entities;
using System;
using System.Globalization;
using System.Xml.Linq;

namespace ExercicioStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 2; i++)
            {
                Comment comment1 = new Comment(Console.ReadLine());
                Comment comment2 = new Comment(Console.ReadLine()); ;
                
                DateTime moment = DateTime.Parse(Console.ReadLine());
                string title = Console.ReadLine();
                string content = Console.ReadLine();
                int likes = int.Parse(Console.ReadLine());
                Post post = new Post(moment, title, content, likes);
                post.addComment(comment1);
                post.addComment(comment2);


                Console.WriteLine(title);
                Console.WriteLine(likes + " Likes - " + moment);
                Console.WriteLine("Comments:");
                Console.WriteLine(post);

                Console.WriteLine();
            }
        }
    }
}
