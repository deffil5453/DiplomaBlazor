namespace DiplomaRealEstate.InputModel
{
	public class RealEstateEditModel
	{
		public Guid Id { get; set; }
		public string Area { get; set; }
		public int Price { get; set; }
		public int Rooms { get; set; }
		public string? Desctiption { get; set; }
		public string Country { get; set; }
		public string Region { get; set; }
		public string? City { get; set; }
		public string? Street { get; set; }
		public string? House { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public string Photos { get; set; }
		public string UserId { get; set; }
		public Guid TypeRealEstateId { get; set; }
		public Guid CategoryId { get; set; }
	}
}
