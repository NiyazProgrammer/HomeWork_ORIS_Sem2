FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MyServiceApi/MyServiceApi.csproj", "MyServiceApi/"]
RUN dotnet restore "MyServiceApi/MyServiceApi.csproj"
COPY . .
WORKDIR "/src/MyServiceApi"
RUN dotnet build "MyServiceApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyServiceApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyServiceApi.dll"]
