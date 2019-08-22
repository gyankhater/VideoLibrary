﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;
using AutoMapper;

namespace Vidly.Controllers.Api
{
		public class CustomersController : ApiController
		{

			private MyDBContext _context;

			public CustomersController()
			{
				_context = new MyDBContext();
			}

			//GET /api/customers
			public IEnumerable<CustomerDto> GetCustomers()
			{
				return _context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDto>);
			}


			//GET /api/customers/1
			public IHttpActionResult GetCustomer(int Id)
			{
				var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);
			if (customer == null)
				return NotFound();

				return Ok(Mapper.Map<Customer,CustomerDto>(customer));
			}

		// POST /api/customers
			[HttpPost]
			public IHttpActionResult CreateCustomer(CustomerDto customerDto)
			{
			if (!ModelState.IsValid)
				return BadRequest();

				var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

				_context.Customers.Add(customer);
				_context.SaveChanges();

				customerDto.Id = customer.Id;

				return Created(new Uri(Request.RequestUri + "/" + customer.Id),customerDto);

			}

			// PUT /api/customers/1
			[HttpPut]
			public void UpdateCustomer(int Id, CustomerDto customerDto)
			{
				if (!ModelState.IsValid)
					throw new HttpResponseException(HttpStatusCode.BadRequest);

				var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == Id);

				if (customerInDb == null)
					throw new HttpResponseException(HttpStatusCode.NotFound);

				Mapper.Map(customerDto,customerInDb);
				//customerInDb.Name = customer.Name;
				//customerInDb.Birthdate = customer.Birthdate;
				//customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
				//customerInDb.MembershipTypeId = customer.MembershipTypeId;

				_context.SaveChanges();
	
			}

			// DELETE /api/customers/1
			[HttpDelete]
			public void DeleteCustomer(int Id)
			{
				var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == Id);

				if (customerInDb == null)
					throw new HttpResponseException(HttpStatusCode.NotFound);

				_context.Customers.Remove(customerInDb);
				_context.SaveChanges();
			}

		}
}
