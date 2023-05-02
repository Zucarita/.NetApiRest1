#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ExApiRest.Webapi/ExApiRest.Webapi.csproj", "ExApiRest.Webapi/"]
COPY ["ExApiRest.Abstractions/ExApiRest.Abstractions.csproj", "ExApiRest.Abstractions/"]
COPY ["ExApiRest.Application/ExApiRest.Application.csproj", "ExApiRest.Application/"]
COPY ["ExApiRest.Entities/ExApiRest.Entities.csproj", "ExApiRest.Entities/"]
COPY ["ExApiRest.Repository/ExApiRest.Repository.csproj", "ExApiRest.Repository/"]
COPY ["ExApiRest.DataAccess/ExApiRest.DataAccess.csproj", "ExApiRest.DataAccess/"]
COPY ["ExApiRest.Services/ExApiRest.Services.csproj", "ExApiRest.Services/"]
RUN dotnet restore "ExApiRest.Webapi/ExApiRest.Webapi.csproj"
COPY . .
WORKDIR "/src/ExApiRest.Webapi"
RUN dotnet build "ExApiRest.Webapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExApiRest.Webapi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExApiRest.Webapi.dll"]