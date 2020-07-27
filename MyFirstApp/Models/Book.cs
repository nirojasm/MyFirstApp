using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nombre { get; set; }
        public String Autor { get; set; }

        public String ISBN { get; set; }
    }
}
