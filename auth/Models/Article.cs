using System;
using System.Data.Entity;
using System.Linq;

namespace auth.Models
{

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}