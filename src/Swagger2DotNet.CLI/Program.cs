// See https://aka.ms/new-console-template for more information

using System.CommandLine;
using Swagger2DotNet.Libs.CommandLine;
using Swagger2DotNet.Libs.Enums;


var specsFile = new Option<FileInfo>(
    name: "--specs",
    description: "Path to Swagger specification file written in Yaml or Json.",
    getDefaultValue: () => new FileInfo("swagger.yaml"));

var format = new Option<SwaggerSpecsFormat>(
    name: "--format",
    description: "Format of Swagger specification file (Yaml or Json).",
    getDefaultValue: () => SwaggerSpecsFormat.Yaml);

var outputDir = new Option<DirectoryInfo>(
    name: "--output",
    description: "Output of the generated sources.",
    getDefaultValue: () => new DirectoryInfo("output"));

var rootCommand = new RootCommand("Generate .NET client API libraries from Swagger specifications.");

rootCommand.AddOption(specsFile);
rootCommand.AddOption(format);
rootCommand.AddOption(outputDir);

rootCommand.SetHandler(async (context) =>
{
    
},new ArgumentContextBinder(specsFile, outputDir, format));

await rootCommand.InvokeAsync(args);