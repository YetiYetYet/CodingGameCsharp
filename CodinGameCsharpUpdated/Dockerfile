FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CodinGameCsharpUpdated/CodinGameCsharpUpdated.csproj", "CodinGameCsharpUpdated/"]
RUN dotnet restore "CodinGameCsharpUpdated/CodinGameCsharpUpdated.csproj"
COPY . .
WORKDIR "/src/CodinGameCsharpUpdated"
RUN dotnet build "CodinGameCsharpUpdated.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodinGameCsharpUpdated.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodinGameCsharpUpdated.dll"]
