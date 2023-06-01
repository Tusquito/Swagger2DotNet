using System.CommandLine;
using System.CommandLine.Binding;
using Swagger2DotNet.Libs.Enums;

namespace Swagger2DotNet.Libs.CommandLine;

public class ArgumentContextBinder : BinderBase<ArgumentsContext>
{
    private readonly Option<FileInfo> _specsFile;
    private readonly Option<SwaggerSpecsFormat> _format;
    public ArgumentContextBinder(Option<FileInfo> specsFile, Option<SwaggerSpecsFormat> format)
    {
        _specsFile = specsFile;
        _format = format;
    }

    protected override ArgumentsContext GetBoundValue(BindingContext bindingContext)
    {
        return new ArgumentsContext
        {
            SpecsFile = bindingContext.ParseResult.GetValueForOption(_specsFile),
            Format = bindingContext.ParseResult.GetValueForOption(_format),
        };
    }
}