﻿FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
COPY bin/Release/netcoreapp2.2/publish/ .
ENTRYPOINT ["dotnet", "TestDocker.dll"]
