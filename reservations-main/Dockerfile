#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["reservations-main/reservation-system.csproj", "reservation-main/"]
RUN dotnet restore "reservation-main/reservation-system.csproj"
COPY . .
WORKDIR "/src/reservation-main"
RUN dotnet build "reservation-system.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "reservation-system.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "reservation-system.dll"]