FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HelloWorldScaling/HelloWorldScaling.csproj", "HelloWorldScaling/"]
RUN dotnet restore "HelloWorldScaling/HelloWorldScaling.csproj"
COPY . .
WORKDIR "/src/HelloWorldScaling"
RUN dotnet build "HelloWorldScaling.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HelloWorldScaling.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloWorldScaling.dll"]
