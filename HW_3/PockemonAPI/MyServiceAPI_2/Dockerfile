FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MyServiceAPI/MyServiceAPI.csproj", "MyServiceAPI/"]
RUN dotnet restore "MyServiceAPI/MyServiceAPI.csproj"
COPY . .
WORKDIR "/src/MyServiceAPI"
RUN dotnet build "MyServiceAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyServiceAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyServiceAPI.dll"]
