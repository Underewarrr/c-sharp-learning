FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy everything
COPY ../ ./

# Build and publish a release
RUN dotnet test StringLibraryTest/StringLibraryTest.csproj

ENTRYPOINT ["dotnet", "HelloWorld.dll"]
