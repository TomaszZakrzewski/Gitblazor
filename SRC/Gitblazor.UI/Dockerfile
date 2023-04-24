FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ModelChecker.Client/ModelChecker.Client.csproj", "ModelChecker.Client/"]
RUN dotnet restore "ModelChecker.Client/ModelChecker.Client.csproj"
COPY . .
WORKDIR "/src/ModelChecker.Client"
RUN dotnet build "ModelChecker.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ModelChecker.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ModelChecker.Client.dll"]
