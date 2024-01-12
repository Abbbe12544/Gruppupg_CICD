FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

WORKDIR /New-TEST

COPY ./application/bin/Debug/net8.0/ .

CMD ["dotnet", "application.dll"]