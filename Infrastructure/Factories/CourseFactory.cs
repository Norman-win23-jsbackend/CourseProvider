using Infrastructure.Data.Entities;
using Infrastructure.Models;
using static Infrastructure.Data.Entities.CourseEntity;

namespace Infrastructure.Factories;

public static class CourseFactory
{


	public static CourseEntity Create(CourseCreateRequest request)
	{
		return new CourseEntity
		{
			ImgUrl = request.ImageUrl,
			ImgHeaderUrl = request.ImageHeaderUrl,
			IsDigital = request.IsDigital,
			IsBestseller = request.IsBestseller,
			Categories = request.Categories,
			Title = request.Title,
			Ingress = request.Ingress,
			StarRating = request.StarRating,
			Reviews = request.Reviews,
			Likes = request.Likes,
			LikePercentage = request.LikePercentage,
			Hours = request.Hours,
			Authors = request.Authors?.Select(author => new AuthorEntity
			{
				Id = author.Id,
				AuthorName = author.AuthorName,
				AuthorDescription = author.AuthorDescription,
				AuthorImageUrl = author.AuthorImageUrl,
				Subscribers = author.Subscribers,
				Followers = author.Followers
			}).ToList(),
			Prices = request.Prices == null ? null : new PriceEntity
			{
				Currency = request.Prices.Currency,
				Price = request.Prices.Price,
				Discount = request.Prices.Discount
			},
			Content = request.Content == null ? null : new ContentEntity
			{
				Description = request.Content.Description,
				Includes = request.Content.Includes,
				ProgramDetails = request.Content.ProgramDetails?.Select(detail => new ProgramDetailItemEntity
				{
					Id = detail.Id,
					Title = detail.Title,
					Description = detail.Description
				}).ToList()
			},
			CategoryEntity = request.CategoryEntity == null ? null : new CategoryEntity
			{
				Id = request.CategoryEntity.Id,
				Name = request.CategoryEntity.Name
			}
		};
	}

	public static CourseEntity Update(CourseUpdateRequest request)
	{
		return new CourseEntity
		{
			Id = request.Id,
			ImgUrl = request.ImageUrl,
			ImgHeaderUrl = request.ImageHeaderUrl,
			IsDigital = request.IsDigital,
			IsBestseller = request.IsBestseller,
			Categories = request.Categories,
			Title = request.Title,
			Ingress = request.Ingress,
			StarRating = request.StarRating,
			Reviews = request.Reviews,
			Likes = request.Likes,
			LikePercentage = request.LikePercentage,
			Hours = request.Hours,
			Authors = request.Authors?.Select(author => new AuthorEntity
			{
				Id = author.Id,
				AuthorName = author.AuthorName,
				AuthorDescription = author.AuthorDescription,
				AuthorImageUrl = author.AuthorImageUrl,
				Subscribers = author.Subscribers,
				Followers = author.Followers
			}).ToList(),
			Prices = request.Prices == null ? null : new PriceEntity
			{
				Currency = request.Prices.Currency,
				Price = request.Prices.Price,
				Discount = request.Prices.Discount
			},
			Content = request.Content == null ? null : new ContentEntity
			{
				Description = request.Content.Description,
				Includes = request.Content.Includes,
				ProgramDetails = request.Content.ProgramDetails?.Select(detail => new ProgramDetailItemEntity
				{
					Id = detail.Id,
					Title = detail.Title,
					Description = detail.Description
				}).ToList()
			},
			CategoryEntity = request.CategoryEntity == null ? null : new CategoryEntity
			{
				Id = request.CategoryEntity.Id,
				Name = request.CategoryEntity.Name
			}
		};
	}

	public static Course Create(CourseEntity entity)
	{
		return new Course
		{
			Id = entity.Id,
			ImgUrl = entity.ImgUrl,
			ImgHeaderUrl = entity.ImgHeaderUrl,
			IsDigital = entity.IsDigital,
			IsBestseller = entity.IsBestseller,
			Categories = entity.Categories,
			Title = entity.Title,
			Ingress = entity.Ingress,
			StarRating = entity.StarRating,
			Reviews = entity.Reviews,
			Likes = entity.Likes,
			LikePercentage = entity.LikePercentage,
			Hours = entity.Hours,
			Authors = entity.Authors?.Select(author => new Author
			{
				Id = author.Id,
				AuthorName = author.AuthorName,
				AuthorDescription = author.AuthorDescription,
				AuthorImageUrl = author.AuthorImageUrl,
				Subscribers = author.Subscribers,
				Followers = author.Followers
			}).ToList(),
			Prices = entity.Prices == null ? null : new Prices
			{
				Currency = entity.Prices.Currency,
				Price = entity.Prices.Price,
				Discount = entity.Prices.Discount
			},
			Content = entity.Content == null ? null : new Content
			{
				Description = entity.Content.Description,
				Includes = entity.Content.Includes,
				ProgramDetails = entity.Content.ProgramDetails?.Select(detail => new ProgramDetailItem
				{
					Id = detail.Id,
					Title = detail.Title,
					Description = detail.Description
				}).ToList()
			},
			CategoryEntity = entity.CategoryEntity == null ? null : new Category
			{
				Id = entity.CategoryEntity.Id,
				Name = entity.CategoryEntity.Name
			}
		};
	}


}

