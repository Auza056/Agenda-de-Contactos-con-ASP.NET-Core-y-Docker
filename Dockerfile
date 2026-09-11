# Compilación / Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copiar el archivo de proyecto y restaurar dependencias
COPY ["VaultContactos.csproj", "./"]
RUN dotnet restore "VaultContactos.csproj"

# Copiar todo el código restante y compilar
COPY . .
RUN dotnet publish "VaultContactos.csproj" -c Release -o /app/publish /p:UseAppHost=false

#  Ejecución 
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "VaultContactos.dll"]