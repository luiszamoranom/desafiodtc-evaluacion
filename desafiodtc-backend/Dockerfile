FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["desafiodtc-backend/desafiodtc-backend.csproj", "desafiodtc-backend/"]
RUN dotnet restore "desafiodtc-backend/desafiodtc-backend.csproj"
COPY . .
WORKDIR "/src/desafiodtc-backend"
RUN dotnet build "desafiodtc-backend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "desafiodtc-backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "desafiodtc-backend.dll"]
