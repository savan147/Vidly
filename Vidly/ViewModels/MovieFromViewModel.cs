using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFromViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }
        // public Movie Movie { get; set; }
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                //if (Movie != null && Movie.Id != 0)
                //    return "Edit Movie";

                //return "New Movie";
                return Id != 0 ? "Edit Movie " : "New Movie";
                
            }
        }
        public MovieFromViewModel()
        {
            Id = 0;
        }
        public MovieFromViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}