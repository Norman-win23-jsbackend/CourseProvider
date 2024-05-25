using Infrastructure.Models;
using Infrastructure.Services;

namespace Infrastructure.GraphQL.Queries;

public class CourseQuery(ICourseService courseService)
{
    private readonly ICourseService _courseService = courseService;




    [GraphQLName("getCourses")]
    public async Task<IEnumerable<Course>> GetCoursesAsync()
    {
        return await _courseService.GetCoursesAsync();
    }





    [GraphQLName("getCourseById")]
    public async Task<Course> GetCourseAsync(string id)
    {
        return await _courseService.GetCourseByIDAsync(id);
    }
}
