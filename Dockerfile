FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY bin/Release/net5.0/publish/ TestDocker/
WORKDIR /TestDocker
ENTRYPOINT ["dotnet", "TestDocker.dll"]