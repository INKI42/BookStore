using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;


namespace BookStore.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }

        public string FullName { get; set; }
        public DateTime Born { get; set; }

        public virtual List<Book> Books { get; set; }

    }
}