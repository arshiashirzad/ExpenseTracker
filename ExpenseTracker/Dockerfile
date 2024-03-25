# Use the official .NET SDK image from Docker Hub
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set the working directory in the container
WORKDIR /app

# Copy the source code into the container
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Define the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

# Set the working directory in the container
WORKDIR /app

# Copy the published application from build stage
COPY --from=build /app/out ./

# Expose the port your app runs on
EXPOSE 80

# Command to run the application
ENTRYPOINT ["dotnet", "ExpenseTracker.dll"]
