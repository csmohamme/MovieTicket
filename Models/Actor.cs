using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Actor")]
        [Required(ErrorMessage = "Actor Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The actor name must be between 3 & 50 chars ")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [StringLength(250, MinimumLength = 5)]
        [Required(ErrorMessage = " Biography is required")]

        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}