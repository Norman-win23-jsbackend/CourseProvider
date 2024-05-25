
namespace Infrastructure.Models;

public class CourseUpdateRequest
{
	public string Id { get; set; } = null!;
	public string? ImageUrl { get; set; }
	public string? ImageHeaderUrl { get; set; }
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
	public List<AuthorUpdateRequest>? Authors { get; set; }
	public PriceUpdateRequest? Prices { get; set; }
	public ContentUpdateRequest? Content { get; set; }
	public CategoryUpdateRequest? CategoryEntity { get; set; }
}

public class AuthorUpdateRequest
{
	public int Id { get; set; }
	public string? AuthorName { get; set; }
	public string? AuthorDescription { get; set; }
	public string? AuthorImageUrl { get; set; }
	public int Subscribers { get; set; }
	public int Followers { get; set; }
}

public class PriceUpdateRequest
{
	public string? Currency { get; set; }
	public decimal Price { get; set; }
	public decimal Discount { get; set; }
}

public class ContentUpdateRequest
{
	public string? Description { get; set; }
	public string[]? Includes { get; set; }
	public List<ProgramDetailItemUpdateRequest>? ProgramDetails { get; set; }
}

public class ProgramDetailItemUpdateRequest
{
	public int Id { get; set; }
	public string? Title { get; set; }
	public string? Description { get; set; }
}

public class CategoryUpdateRequest
{
	public int Id { get; set; }
	public string? Name { get; set; }
}

