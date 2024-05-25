namespace Infrastructure.Data.Entities;

public partial class CourseEntity
{
	public class PriceEntity
	{
		public string? Currency  { get; set; }
		public decimal Price { get; set; }
		public decimal Discount { get; set; }

	}

}
