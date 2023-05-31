using System.CommandLine;
using System.CommandLine.Binding;
using Swagger2DotNet.Libs.Enums;

namespace Swagger2DotNet.Libs.CommandLine;

public class ArgumentContextBinder : BinderBase<ArgumentsContext>
{
    private readonly Option<FileInfo> _specsFile;
    private readonly Option<SwaggerSpecsFormat> _format;
    private readonly Option<DirectoryInfo> _outputDir;

    public ArgumentContextBinder(Option<FileInfo> specsFile, Option<DirectoryInfo> outputDir, Option<SwaggerSpecsFormat> format)
    {
        _specsFile = specsFile;
        _outputDir = outputDir;
        _format = format;
    }

    protected override ArgumentsContext GetBoundValue(BindingContext bindingContext)
    {
        return new ArgumentsContext
        {
            SpecsFile = bindingContext.ParseResult.GetValueForOption(_specsFile),
            Format = bindingContext.ParseResult.GetValueForOption(_format),
            OutputDir = bindingContext.ParseResult.GetValueForOption(_outputDir)
        };
    }
}