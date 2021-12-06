#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["MicroServiceEmpleados/MicroServiceEmpleados.csproj", "MicroServiceEmpleados/"]
RUN dotnet restore "MicroServiceEmpleados/MicroServiceEmpleados.csproj"
COPY . .
WORKDIR "/src/MicroServiceEmpleados"
RUN dotnet build "MicroServiceEmpleados.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroServiceEmpleados.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroServiceEmpleados.dll"]