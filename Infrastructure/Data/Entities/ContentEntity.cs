namespace Infrastructure.Data.Entities;

public partial class CourseEntity
{
	public class ContentEntity
	{
		public string? Description { get; set; }
		public string[]? Includes { get; set; }
		public virtual List<ProgramDetailItemEntity> ? ProgramDetails { get; set; }

	}

}
