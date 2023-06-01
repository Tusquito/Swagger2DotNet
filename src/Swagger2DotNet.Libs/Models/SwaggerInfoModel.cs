namespace Swagger2DotNet.Libs.Models;

public class SwaggerInfoModel
{
    public required string Title { get; init; }
    public required string Version { get; init; }
    public string? Description { get; init; }
}