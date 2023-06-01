using Swagger2DotNet.Libs.Enums;

namespace Swagger2DotNet.Libs.Models;

public class SwaggerFileModel
{
    public SwaggerInfoModel Info { get; init; }
    public List<SwaggerServerModel> Servers { get; init; }
    public Dictionary<string, SwaggerPathModel> Paths { get; init; }
    public SwaggerComponentsModel Components { get; init; }
}