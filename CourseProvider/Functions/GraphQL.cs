using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace CourseProvider.Functions;

public class GraphQL(ILogger<GraphQL> logger, IGraphQLRequestExecutor requestExecutor)
{
    private readonly ILogger<GraphQL> _logger = logger;
    private readonly IGraphQLRequestExecutor _requestExecutor = requestExecutor;






    [Function("GraphQL")]
    public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "graphql")] HttpRequest req)
    {
        return await _requestExecutor.ExecuteAsync(req);
    }
}
