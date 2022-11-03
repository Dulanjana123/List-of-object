using System;
using System.Collections.Generic;
using System.Text;


    public class Author
    {
        public string name { get; set; }
        public short age { get; set; }
        public string title { get; set; }
        public bool mvp { get; set; }


    public Author(string name, short age, string title, bool mvp)
        {
            this.name = name;
            this.age = age;
            this.title = title;
            this.mvp = mvp;
        }

    }

