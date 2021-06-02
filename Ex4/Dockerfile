FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Ex4/Ex4.csproj", "Ex4/"]
RUN dotnet restore "Ex4/Ex4.csproj"
COPY . .
WORKDIR "/src/Ex4"
RUN dotnet build "Ex4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ex4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ex4.dll"]
