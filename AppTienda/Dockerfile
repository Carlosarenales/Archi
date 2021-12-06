#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["AppTienda/AppTienda.csproj", "AppTienda/"]
RUN dotnet restore "AppTienda/AppTienda.csproj"
COPY . .
WORKDIR "/src/AppTienda"
RUN dotnet build "AppTienda.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AppTienda.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AppTienda.dll"]