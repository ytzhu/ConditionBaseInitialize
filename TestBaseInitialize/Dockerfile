#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY ["TestBaseInitialize/TestBaseInitialize.csproj", "TestBaseInitialize/"]
RUN dotnet restore "TestBaseInitialize/TestBaseInitialize.csproj"
COPY . .
WORKDIR "/src/TestBaseInitialize"
RUN dotnet build "TestBaseInitialize.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TestBaseInitialize.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TestBaseInitialize.dll"]