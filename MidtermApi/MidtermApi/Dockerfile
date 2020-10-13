#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ARG VACATION_COPPER_ARG
ENV VACATION_COPPER=$VACATION_COPPER_ARG

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MidtermApi.csproj", "./"]
RUN dotnet restore "./MidtermApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "MidtermApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MidtermApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet MidtermApi.dll
