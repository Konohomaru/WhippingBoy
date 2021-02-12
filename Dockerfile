FROM mcr.microsoft.com/dotnet/aspnet:3.1

EXPOSE 80

COPY ["Source/WebAPI/bin/Release/netcoreapp3.1/publish/", "App/"]
WORKDIR App/
ENTRYPOINT ["dotnet", "WebAPI.dll"]
