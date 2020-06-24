FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY alice/*.csproj ./alice/
RUN dotnet restore

# copy everything else and build app
COPY alice/. ./alice/
WORKDIR /source/alice
RUN dotnet publish -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.1
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "alice.dll"]