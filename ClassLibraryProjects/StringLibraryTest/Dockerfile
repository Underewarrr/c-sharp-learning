FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy everything
COPY . ./

# Build and publish a release
RUN dotnet test StringLibraryTest/StringLibraryTest.csproj

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

ENTRYPOINT ["dotnet", "HelloWorld.dll"]
