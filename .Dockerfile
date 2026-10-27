# Estágio de Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copia o csproj e restaura as dependências
COPY *.csproj ./
RUN dotnet restore

# Copia o resto do código e faz o publish
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Estágio de Execução (Runtime)
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish .

# Substitua "SuaApi.dll" pelo nome exato do seu assembly gerado (geralmente o nome do seu projeto)
ENTRYPOINT ["dotnet", "SuaApi.dll"]
