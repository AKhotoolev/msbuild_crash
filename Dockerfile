FROM mcr.microsoft.com/dotnet/sdk:3.1-alpine AS cw-build-env

WORKDIR /app
COPY ./ ./
RUN dotnet restore

RUN dotnet build -v:detailed