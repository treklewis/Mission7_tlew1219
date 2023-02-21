using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_tlew1219.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int AppliationID { get; set; }

        //Foreign key relationship from movie to category
        [Required(ErrorMessage ="Please select a category")]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Please select a category")]
        public Category Category { get; set; }

        [Required(ErrorMessage = "Please enter a movie title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the year the movie was released")]
        public int? Year { get; set; }
        [Required(ErrorMessage = "Please enter the director for this movie")]
        public string Director { get; set; }
        [Required(ErrorMessage ="Please select a rating")]
        public string Rating { get; set; }

        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25, ErrorMessage = "Notes are limited to 25 characters.")]
        public string Notes { get; set; }
    }
}
