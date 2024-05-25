
namespace Infrastructure.Models;

public class CourseCreateRequest
{
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
	public List<AuthorCreateRequest>? Authors { get; set; }
	public PriceCreateRequest? Prices { get; set; }
	public ContentCreateRequest? Content { get; set; }
	public CategoryCreateRequest? CategoryEntity { get; set; }
}

public class AuthorCreateRequest
{
	public int Id { get; set; }
	public string? AuthorName { get; set; }
	public string? AuthorDescription { get; set; }
	public string? AuthorImageUrl { get; set; }
	public int Subscribers { get; set; }
	public int Followers { get; set; }
}

public class PriceCreateRequest
{
	public string? Currency { get; set; }
	public decimal Price { get; set; }
	public decimal Discount { get; set; }
}

public class ContentCreateRequest
{
	public string? Description { get; set; }
	public string[]? Includes { get; set; }
	public List<ProgramDetailItemCreateRequest>? ProgramDetails { get; set; }
}

public class ProgramDetailItemCreateRequest
{
	public int Id { get; set; }
	public string? Title { get; set; }
	public string? Description { get; set; }
}

public class CategoryCreateRequest
{
	public int Id { get; set; }
	public string? Name { get; set; }
}

