using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket.Models
{
    public class Producer

    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Producer")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}