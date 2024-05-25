using Infrastructure.Data.Entities;
using static Infrastructure.Data.Entities.CourseEntity;

namespace Infrastructure.GraphQL.ObjectTypes;

public class CourseType : ObjectType<CourseEntity>
{
	protected override void Configure(IObjectTypeDescriptor<CourseEntity> descriptor)
	{
		descriptor.Field(c => c.Id).Type<NonNullType<IdType>>();
		descriptor.Field(c => c.ImgUrl).Type<StringType>();
		descriptor.Field(c => c.ImgHeaderUrl).Type<StringType>();
		descriptor.Field(c => c.IsDigital).Type<BooleanType>();
		descriptor.Field(c => c.IsBestseller).Type<BooleanType>();
		descriptor.Field(c => c.Categories).Type<ListType<StringType>>();
		descriptor.Field(c => c.Title).Type<StringType>();
		descriptor.Field(c => c.Ingress).Type<StringType>();
		descriptor.Field(c => c.StarRating).Type<DecimalType>();
		descriptor.Field(c => c.Reviews).Type<StringType>();
		descriptor.Field(c => c.Likes).Type<StringType>();
		descriptor.Field(c => c.LikePercentage).Type<StringType>();
		descriptor.Field(c => c.Hours).Type<StringType>();
		descriptor.Field(c => c.Authors).Type<ListType<AuthorType>>();
		descriptor.Field(c => c.Prices).Type<PriceType>();
		descriptor.Field(c => c.Content).Type<ContentType>();
		descriptor.Field(c => c.CategoryEntity).Type<CategoryType>();
	}
}

public class AuthorType : ObjectType<AuthorEntity>
{
	protected override void Configure(IObjectTypeDescriptor<AuthorEntity> descriptor)
	{
		descriptor.Field(a => a.Id).Type<NonNullType<IdType>>();
		descriptor.Field(a => a.AuthorName).Type<StringType>();
		descriptor.Field(a => a.AuthorDescription).Type<StringType>();
		descriptor.Field(a => a.AuthorImageUrl).Type<StringType>();
		descriptor.Field(a => a.Subscribers).Type<IntType>();
		descriptor.Field(a => a.Followers).Type<IntType>();
	}
}

public class CategoryType : ObjectType<CategoryEntity>
{
	protected override void Configure(IObjectTypeDescriptor<CategoryEntity> descriptor)
	{
		descriptor.Field(c => c.Id).Type<NonNullType<IdType>>();
		descriptor.Field(c => c.Name).Type<StringType>();
	}
}

public class ContentType : ObjectType<ContentEntity>
{
	protected override void Configure(IObjectTypeDescriptor<ContentEntity> descriptor)
	{
		descriptor.Field(c => c.Description).Type<StringType>();
		descriptor.Field(c => c.Includes).Type<ListType<StringType>>();
		descriptor.Field(c => c.ProgramDetails).Type<ListType<ProgramDetailItemType>>();
	}
}

public class PriceType : ObjectType<PriceEntity>
{
	protected override void Configure(IObjectTypeDescriptor<PriceEntity> descriptor)
	{
		descriptor.Field(p => p.Currency).Type<StringType>();
		descriptor.Field(p => p.Price).Type<DecimalType>();
		descriptor.Field(p => p.Discount).Type<DecimalType>();
	}
}

public class ProgramDetailItemType : ObjectType<ProgramDetailItemEntity>
{
	protected override void Configure(IObjectTypeDescriptor<ProgramDetailItemEntity> descriptor)
	{
		descriptor.Field(p => p.Id).Type<NonNullType<IdType>>();
		descriptor.Field(p => p.Title).Type<StringType>();
		descriptor.Field(p => p.Description).Type<StringType>();
	}
}

