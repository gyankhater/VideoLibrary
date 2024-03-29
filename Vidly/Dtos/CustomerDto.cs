﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
	public class CustomerDto
	{
		public int Id { get; set; }

		[StringLength(255)]
		[Required]
		public string Name { get; set; }

		public bool IsSubscribedToNewsLetter { get; set; }		

		public byte MembershipTypeId { get; set; }

		public MembershipTypeDto MembershipType { get; set; }
																			 //[Min18YearsIfAMember]
		public DateTime? Birthdate { get; set; }
	}
}