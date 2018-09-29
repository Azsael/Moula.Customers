FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 64658
EXPOSE 44382

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Moula.Customers.API/Moula.Customers.API.csproj Moula.Customers.API/
RUN dotnet restore Moula.Customers.API/Moula.Customers.API.csproj
COPY . .
WORKDIR /src/Moula.Customers.API
RUN dotnet build Moula.Customers.API.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Moula.Customers.API.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Moula.Customers.API.dll"]
