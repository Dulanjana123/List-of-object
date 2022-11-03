using System;
using System.Collections.Generic;

namespace List_of_object
{
    public class Program
    {
        static void Main(string[] args)
        {
            //The following code snippet creates a List of Author type.
            List<Author> Authorlist = new List<Author>();

            //The following code snippet creates the Author objects and adds them to the List.
            Authorlist.Add ( new Author ("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true) );
            Authorlist.Add(new Author("Neel Beniwal", 18, "Graphics Development with C#", false));

            //The following code snippets loop through the List and prints out all the items of the List.
            foreach (var author in Authorlist)
            {
                Console.WriteLine("Author: {0},{1},{2},{3}", author.name, author.age, author.title, author.mvp);
            }   
        }
    }
}
