using Infrastructure.Data.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Infrastructure.Services;

public interface ICourseService
{

	Task<Course> CreateCourseAsync(CourseCreateRequest request);
	Task<Course> GetCourseByIDAsync(string id);
	Task<IEnumerable<Course>> GetCoursesAsync();
	Task<Course> UpdateCourseAsync(CourseUpdateRequest request);
	Task<bool> DeleteCourseAsync(string id);
}





public class CourseService(IDbContextFactory<DataContext> contextFactory) : ICourseService
{
	private readonly IDbContextFactory<DataContext> _contextFactory = contextFactory;




	public async Task<Course> CreateCourseAsync(CourseCreateRequest request)
	{
		try
		{
			await using var context = _contextFactory.CreateDbContext();
			var courseEntity = CourseFactory.Create(request);
			context.Courses.Add(courseEntity);
			await context.SaveChangesAsync();
			return CourseFactory.Create(courseEntity);
		}
        catch (Exception ex)
        {
            Debug.WriteLine($"Error creating course: {ex.Message}");
            return null!;
        }
    }

	public async Task<bool> DeleteCourseAsync(string id)
	{
		try
		{
			await using var context = _contextFactory.CreateDbContext();
			var courseEntity = await context.Courses.FirstOrDefaultAsync(c => c.Id == id);
			if (courseEntity == null) 
				return false;

			context.Courses.Remove(courseEntity);
			await context.SaveChangesAsync();
			return true;
		}
		catch (Exception ex)
		{
            //error mesg
            Debug.WriteLine($"Error deleting course: {ex.Message}");
            return false;
        }
	}

    public async Task<Course> GetCourseByIDAsync(string id)
    {
        try
        {
            await using var dbContext = _contextFactory.CreateDbContext();
            var courseEntity = await dbContext.Courses.FirstOrDefaultAsync(c => c.Id == id);
            return courseEntity == null ? null! : CourseFactory.Create(courseEntity);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error retrieving course by ID: {ex.Message}");
            return null!;
        }
    }


    public async Task<IEnumerable<Course>> GetCoursesAsync()
	{
		try
		{
			await using var context = _contextFactory.CreateDbContext();
			var courseEntities = await context.Courses.ToListAsync();
			return courseEntities == null ? null! : courseEntities.Select( CourseFactory.Create);
		}
        catch (Exception ex)
        {
            Debug.WriteLine($"Error retrieving courses: {ex.Message}");
            return null!;
        }
    }

	public async Task<Course> UpdateCourseAsync(CourseUpdateRequest request)
	{
		try
		{
			await using var context = _contextFactory.CreateDbContext();
			var existingCourse = await context.Courses.FirstOrDefaultAsync(c => c.Id == request.Id);
			if (existingCourse == null) return null!;

			var updateCourseEntity = CourseFactory.Update(request);
			updateCourseEntity.Id = existingCourse.Id;
			context.Entry(existingCourse).CurrentValues.SetValues(updateCourseEntity);
			await context.SaveChangesAsync();
			return CourseFactory.Create(existingCourse);
		}
        catch (Exception ex)
        {
            Debug.WriteLine($"Error updating course: {ex.Message}");
            return null!;
        }
    }



}
