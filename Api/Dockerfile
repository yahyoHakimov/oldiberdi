# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy everything and restore NuGet packages
COPY . ./
RUN dotnet restore

# Build the application
RUN dotnet build -c Release -o out

# Publish the app
RUN dotnet publish -c Release -o out

# Use the official .NET runtime image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy the compiled code from the build container to the runtime container
COPY --from=build-env /app/out .

# Set environment variables if necessary
ENV ASPNETCORE_URLS=http://+:5000

# Expose port 5000 for the API
EXPOSE 5000

# Run the application
ENTRYPOINT ["dotnet", "Api.dll"]
