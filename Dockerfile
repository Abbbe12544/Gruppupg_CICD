FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

WORKDIR /NEW-TEST

COPY ./bin/Debug/net8.0/ .

CMD ["dotnet", "application.dll"]