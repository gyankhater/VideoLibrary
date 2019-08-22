using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
	public class MovieDto
	{
		public int Id { get; set; }

		[StringLength(255)]
		[Required]
		public string Name { get; set; }

		public Genre Genre { get; set; }

		[Required]
		public byte GenreId { get; set; }

		public DateTime DateAdded { get; set; }

		[Required]
		public DateTime ReleaseDate { get; set; }

		[Required]
		[Range(1, 20)]
		public int NumberInStock { get; set; }
	}
}