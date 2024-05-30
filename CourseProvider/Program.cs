using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Infrastructure.GraphQL.ObjectTypes;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data.Contexts;
using Infrastructure.Services;
using Infrastructure.GraphQL.Mutations;
using Infrastructure.GraphQL.Queries;

var host = new HostBuilder()
	.ConfigureFunctionsWebApplication()
	.ConfigureServices(services =>
	{
		services.AddApplicationInsightsTelemetryWorkerService();
		services.ConfigureFunctionsApplicationInsights();

			
        services.AddPooledDbContextFactory<DataContext>(x =>
        {
            x.UseCosmos(Environment.GetEnvironmentVariable("COSMOS_URI")!, Environment.GetEnvironmentVariable("COSMOS_DBNAME")!)
             .UseLazyLoadingProxies();
        });

        services.AddScoped<ICourseService, CourseService>();

		services.AddGraphQLFunction()
				.AddQueryType<CourseQuery>()
				.AddMutationType<CourseMutation>()
				.AddType<CourseType>();

        //SP meaning Service-Provider
        var sp = services.BuildServiceProvider();
		using var scope = sp.CreateScope();
		var dbContextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<DataContext>>();
		using var context = dbContextFactory.CreateDbContext();
		context.Database.EnsureCreated();

	})
	.Build();

host.Run();
