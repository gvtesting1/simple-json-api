FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# copy project file(s) and restore dependencies
COPY ["SimpleJsonApi.csproj", "./"]
RUN dotnet restore "SimpleJsonApi.csproj"

# copy everything and publish
COPY . .
RUN dotnet publish "SimpleJsonApi.csproj" -c Release -o /app/publish

# runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "SimpleJsonApi.dll"]