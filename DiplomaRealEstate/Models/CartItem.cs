﻿namespace DiplomaRealEstate.Models
{
	public class CartItem
	{
		public Guid Id { get; set; }
		
		public Guid RealEstateId { get; set; }
		public string UserId { get; set; }
		public RealEstate RealEstate { get; set; }
		public User User { get; set; }
	}
}
