# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy riêng csproj
COPY Idol.Livestream.API/*.csproj Idol.Livestream.API/
RUN dotnet restore Idol.Livestream.API/Idol.Livestream.API.csproj

# Copy chỉ project folder để giảm build context
COPY Idol.Livestream.API/. Idol.Livestream.API/
RUN dotnet publish Idol.Livestream.API/Idol.Livestream.API.csproj -c Release -o /app/out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Biến môi trường PORT do Render cấp
ARG PORT=8080
ENV ASPNETCORE_URLS=http://*:${PORT}

ENTRYPOINT ["dotnet", "Idol.Livestream.API.dll"]
