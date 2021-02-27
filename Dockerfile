# Building entire solution.
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS sdk
WORKDIR /app
COPY Source/ src/
RUN dotnet build -o builds/ -c Release --nologo src/

# Run model tests.
RUN dotnet test --nologo src/ModelTests/

# Publish Web API.
RUN dotnet publish -o publish/ -c Release src/WebAPI/

# Run Web API.
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=sdk app/publish/ publish/
CMD ASPNETCORE_URLS=http://*:$PORT dotnet publish/WebAPI.dll