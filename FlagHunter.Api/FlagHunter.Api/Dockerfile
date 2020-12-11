#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY . .
RUN dotnet restore "FlagHunter.Api.csproj"
RUN dotnet tool install --global dotnet-ef
RUN export PATH="$PATH:$HOME/.dotnet/tools/"
RUN dotnet ef migrations script example_script
# WORKDIR "/src/FlagHunter.Api"
RUN dotnet build "FlagHunter.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FlagHunter.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=build /src/entrypoint.sh .
# COPY --from=build /src/entrypoint.sh . example_script
RUN chmod +x /app/entrypoint.sh
# ENTRYPOINT ["/app/entrypoint.sh"]