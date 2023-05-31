FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Swagger2DotNet.CLI/Swagger2DotNet.CLI.csproj", "src/Swagger2DotNet.CLI/"]
RUN dotnet restore "src/Swagger2DotNet.CLI/Swagger2DotNet.CLI.csproj"
COPY . .
WORKDIR "/src/src/Swagger2DotNet.CLI"
RUN dotnet build "Swagger2DotNet.CLI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Swagger2DotNet.CLI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Swagger2DotNet.CLI.dll"]
