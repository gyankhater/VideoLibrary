using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
	public class Movie
	{
		public int Id { get; set; }

		[StringLength(255)]
		[Required(ErrorMessage = "Please enter movie name.")]
		public string Name { get; set; }

		public Genre Genre { get; set; }

		[Required]
		[Display(Name = "Genre")]
		public byte GenreId { get; set; }

		public DateTime DateAdded { get; set; }

		[Display(Name="Release Date")]
		[Required]
		public DateTime ReleaseDate { get; set; }

		[Display(Name="Number in Stock")]
		[Required]
		[Range(1, 20)]
		public int NumberInStock { get; set; }
       
        [Range(1, 20)]
        public int NumberAvailable { get; set; }
    }
}