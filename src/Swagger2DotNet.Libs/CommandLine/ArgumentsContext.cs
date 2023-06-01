using Swagger2DotNet.Libs.Enums;

namespace Swagger2DotNet.Libs.CommandLine;

public class ArgumentsContext
{
    public required FileInfo? SpecsFile { get; init; }
    public required SwaggerSpecsFormat Format { get; init; }
}