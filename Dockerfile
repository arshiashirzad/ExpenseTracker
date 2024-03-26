FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
 
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ExpenseTracker/ExpenseTracker.csproj", "ExpenseTracker/"]
RUN dotnet restore "ExpenseTracker/ExpenseTracker.csproj"
COPY . .
WORKDIR "/src/ExpenseTracker"
RUN dotnet build "ExpenseTracker.csproj" -c Release -o /app/build
 
FROM build AS publish
RUN dotnet publish "ExpenseTracker.csproj" -c Release -o /app/publish /p:UseAppHost=false
 
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExpenseTracker.dll"]