﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Models;
using Vidly.Dtos;
using System.Data.Entity;

namespace Vidly.Controllers.Api
{
        [Authorize]
		public class MoviesController : ApiController
		{
			private MyDBContext _context;

		public MoviesController()
		{
			_context = new MyDBContext();
		}

		public IHttpActionResult GetMovies(string query = null)
		{
            var moviesQuery = _context.Movies
                .Include(g => g.Genre)
                .Where(g => g.NumberAvailable > 0);

            if (!String.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(m => m.Name.Contains(query));

            var movieDto = moviesQuery
                .ToList()
                .Select(Mapper.Map<Movie, MovieDto>);

            return Ok(movieDto);
		}

        //GET /api/customers/1
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult GetMovie(int Id)
		{
			var movie = _context.Movies.SingleOrDefault(c => c.Id == Id);
			if (movie == null)
				return NotFound();

			return Ok(Mapper.Map<Movie, MovieDto>(movie));
		}

		[HttpPost]
        [Authorize(Roles = RoleName.CanManageMovies)]
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
        [Authorize(Roles = RoleName.CanManageMovies)]
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
        [Authorize(Roles = RoleName.CanManageMovies)]
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
