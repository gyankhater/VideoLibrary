using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
		public class MoviesController : ApiController
		{
			private MyDBContext _context;

		public MoviesController()
		{
			_context = new MyDBContext();
		}

		public IEnumerable<MovieDto> GetMovies()
		{
			return _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);			
		}

		//GET /api/customers/1
		public IHttpActionResult GetMovie(int Id)
		{
			var movie = _context.Movies.SingleOrDefault(c => c.Id == Id);
			if (movie == null)
				return NotFound();

			return Ok(Mapper.Map<Movie, MovieDto>(movie));
		}

		[HttpPost]
		public IHttpActionResult CreateMovie(MovieDto movieDto)

		{
			if (!ModelState.IsValid)
				return BadRequest();

			var movie = Mapper.Map<MovieDto,Movie> (movieDto);

			_context.Movies.Add(movie);
			_context.SaveChanges();

			movieDto.Id = movie.Id;

			return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);

		}

		[HttpPut]
		public void UpdateMovie(int Id, MovieDto movieDto)
		{
			if (!ModelState.IsValid)
				throw new HttpResponseException(HttpStatusCode.BadRequest);

			var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == Id);

			if (movieInDb == null)
				throw new HttpResponseException(HttpStatusCode.NotFound);

			Mapper.Map(movieDto, movieInDb);
			_context.SaveChanges();			
		}


		[HttpDelete]
		public void DeleteMovie(int Id)
		{
			var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == Id);

			if (movieInDb == null)
				throw new HttpResponseException(HttpStatusCode.NotFound);

			_context.Movies.Remove(movieInDb);
			_context.SaveChanges();



		}

	}
}
