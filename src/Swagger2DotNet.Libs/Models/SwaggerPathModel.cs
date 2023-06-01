using Swagger2DotNet.Libs.Enums;
using YamlDotNet.Serialization;

namespace Swagger2DotNet.Libs.Models;

public class SwaggerPathModel : Dictionary<HttpMethodType, List<SwaggerPathItemModel>>
{
    public string? Summary { get; init; }
    public string? Description { get; init; }
}

public class SwaggerPathItemModel
{
    public string? Summary { get; init; }
    public string? Description { get; init; }
    public string? OperationId { get; init; }   
    public List<string>? Tags { get; init; }
    public List<SwaggerParameterModel>? Parameters { get; init; }
    public required Dictionary<string, SwaggerPathResponseModel> Responses { get; init; }
}

public class SwaggerParameterModel
{
    public required string Name { get; init; }
    public required ParameterType In { get; init; }
    public string? Description { get; init; }
    public bool Required { get; init; }
    public bool Deprecated { get; init; }
    public required SwaggerSchemaParameterModel Schema { get; init; }
}

public class SwaggerSchemaParameterModel
{
    public required string Type { get; init; }
    public string? Format { get; init; }
    public string[]? Enum { get; init; }
    public bool Nullable { get; init; }
    public int? Minimum { get; init; }
    public int? Maximum { get; init; }
    public object? Default { get; init; }
    public SwaggerSchemaParameterItems? Items { get; init; }
}

public class SwaggerSchemaParameterItems
{
    public required string Type { get; init; }
}

public class SwaggerPathResponseModel
{
    public TYPE Type { get; set; }
}