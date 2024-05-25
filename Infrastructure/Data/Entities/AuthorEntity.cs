namespace Infrastructure.Data.Entities;

public partial class CourseEntity
{
	public class AuthorEntity
	{
		public int Id { get; set; }
		public string? AuthorName { get; set; }
		public string? AuthorDescription { get; set; }
		public string? AuthorImageUrl { get; set; }
		public int Subscribers { get; set; }
		public int Followers { get; set; }

	}

}
