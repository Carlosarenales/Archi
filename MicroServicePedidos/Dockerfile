#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["MicroServicePedidos/MicroServicePedidos.csproj", "MicroServicePedidos/"]
RUN dotnet restore "MicroServicePedidos/MicroServicePedidos.csproj"
COPY . .
WORKDIR "/src/MicroServicePedidos"
RUN dotnet build "MicroServicePedidos.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroServicePedidos.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroServicePedidos.dll"]