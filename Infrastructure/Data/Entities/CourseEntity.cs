
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities;

public partial class CourseEntity
{
	[Key]
	public string Id { get; set; } = Guid.NewGuid().ToString();
	public string? ImgUrl { get; set; }
	public string? ImgHeaderUrl { get; set; }
	public bool IsDigital { get; set; }
	public bool IsBestseller { get; set; }
	public string[]? Categories { get; set; }
	public string? Title { get; set; }
	public string? Ingress { get; set; }
	public decimal StarRating { get; set; }
	public string? Reviews { get; set; }
	public string? Likes { get; set; }
	public string? LikePercentage { get; set; }
	public string? Hours { get; set; }
	public virtual List<AuthorEntity>? Authors { get; set; }
	public virtual PriceEntity? Prices { get; set; }
	public virtual ContentEntity? Content { get; set; }
	public virtual CategoryEntity? CategoryEntity { get; set; }
}
