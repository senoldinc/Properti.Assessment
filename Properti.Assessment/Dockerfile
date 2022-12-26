FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Properti.Assessment/Properti.Assessment.csproj", "Properti.Assessment/"]
RUN dotnet restore "Properti.Assessment/Properti.Assessment.csproj"
COPY . .
WORKDIR "/src/Properti.Assessment"
RUN dotnet build "Properti.Assessment.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Properti.Assessment.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Properti.Assessment.dll"]
