FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Ex3/Ex3.csproj", "Ex3/"]
RUN dotnet restore "Ex3/Ex3.csproj"
COPY . .
WORKDIR "/src/Ex3"
RUN dotnet build "Ex3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ex3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ex3.dll"]
