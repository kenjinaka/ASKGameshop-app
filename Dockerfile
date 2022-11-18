FROM mcr.microsoft.com/dotnet/aspnet:2.1-focal AS base
WORKDIR /app

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:2.1-focal AS build
WORKDIR /src
COPY ["AskgAPI/ASKGameShopAPI.csproj", "AskgAPI/"]
RUN dotnet restore "AskgAPI/ASKGameShopAPI.csproj"
COPY . .
WORKDIR "/src/RakAPI"
RUN dotnet build "ASKGameShopAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ASKGameShopAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

CMD ASPNETCORE_URLS="http://*:$PORT" dotnet ASKGameShopAPI.dll
