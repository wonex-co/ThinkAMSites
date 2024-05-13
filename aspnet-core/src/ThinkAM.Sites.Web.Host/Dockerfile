FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/ThinkAM.Sites.Web.Host/ThinkAM.Sites.Web.Host.csproj", "src/ThinkAM.Sites.Web.Host/"]
COPY ["src/ThinkAM.Sites.Web.Core/ThinkAM.Sites.Web.Core.csproj", "src/ThinkAM.Sites.Web.Core/"]
COPY ["src/ThinkAM.Sites.Application/ThinkAM.Sites.Application.csproj", "src/ThinkAM.Sites.Application/"]
COPY ["src/ThinkAM.Sites.Core/ThinkAM.Sites.Core.csproj", "src/ThinkAM.Sites.Core/"]
COPY ["src/ThinkAM.Sites.EntityFrameworkCore/ThinkAM.Sites.EntityFrameworkCore.csproj", "src/ThinkAM.Sites.EntityFrameworkCore/"]
WORKDIR "/src/src/ThinkAM.Sites.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ThinkAM.Sites.Web.Host", "src/ThinkAM.Sites.Web.Host"]
COPY ["src/ThinkAM.Sites.Web.Core", "src/ThinkAM.Sites.Web.Core"]
COPY ["src/ThinkAM.Sites.Application", "src/ThinkAM.Sites.Application"]
COPY ["src/ThinkAM.Sites.Core", "src/ThinkAM.Sites.Core"]
COPY ["src/ThinkAM.Sites.EntityFrameworkCore", "src/ThinkAM.Sites.EntityFrameworkCore"]
WORKDIR "/src/src/ThinkAM.Sites.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ThinkAM.Sites.Web.Host.dll"]
