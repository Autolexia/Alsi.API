#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

EXPOSE 5000
# Ensure we listen on any IP Address 
ENV DOTNET_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Alsi.API.csproj", "Alsi.API/"]
RUN dotnet restore "Alsi.API/Alsi.API.csproj"
WORKDIR "/src/Alsi.API"
COPY . .
RUN dotnet build "Alsi.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Alsi.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Alsi.API.dll"]