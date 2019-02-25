#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY ["capaPresentacions/capaPresentacions.csproj", "capaPresentacions/"]
RUN dotnet restore "capaPresentacions/capaPresentacions.csproj"
COPY . .
WORKDIR "/src/capaPresentacions"
RUN dotnet build "capaPresentacions.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "capaPresentacions.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "capaPresentacions.dll"]