﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
	public class Customer
	{
		public int Id { get; set; }

		[StringLength(255)]
		[Required(ErrorMessage ="Please enter customer's name.")]
		public string Name { get; set; }

		public bool IsSubscribedToNewsLetter{ get; set; }

		public MembershipType MembershipType { get; set; }

		[Display(Name="Membership Type")]
		public byte MembershipTypeId { get; set; }

		[Display(Name="Date of Birth")]
		[Min18YearsIfAMember]
		public DateTime? Birthdate { get; set; }
	}
}