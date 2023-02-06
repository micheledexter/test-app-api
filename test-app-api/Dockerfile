FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["test-app-api/test-app-api.csproj", "test-app-api/"]
RUN dotnet restore "test-app-api/test-app-api.csproj"
COPY . .
WORKDIR "/src/test-app-api"
RUN dotnet build "test-app-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "test-app-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "test-app-api.dll"]
