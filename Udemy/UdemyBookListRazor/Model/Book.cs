using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyBookListRazor.Model
{
    public class Book
    {
        [Key] //automatically add id as identical ID
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
