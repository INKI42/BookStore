using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }


        public string Title { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public string Poster { get; set; }
        public string Genre { get; set; }   

        [MaxLength(int.MaxValue)]
        public string Description { get; set; }

        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }



    }
}