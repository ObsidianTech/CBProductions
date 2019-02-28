FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CBPVideoAPI/CBPVideoAPI.csproj", "CBPVideoAPI/"]
RUN dotnet restore "CBPVideoAPI/CBPVideoAPI.csproj"
COPY . .
WORKDIR "/src/CBPVideoAPI"
RUN dotnet build "CBPVideoAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CBPVideoAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CBPVideoAPI.dll"]