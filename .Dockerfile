FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

# Copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore

# RUN apt-get update -yq && apt-get upgrade -yq && apt-get install -yq curl git nano
# RUN curl -sL https://deb.nodesource.com/setup_8.x | bash - && apt-get install -yq nodejs build-essential
# RUN npm install -g npm

# Copy everything else and build
WORKDIR /api
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /api
COPY --from=build-env /app/out .
ENV ASPNETCORE_Environment production
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Api.dll
