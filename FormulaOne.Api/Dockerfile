FROM mcr.microsoft.com/dotnet/sdk:7.0 as build

WORKDIR /app

EXPOSE 80

EXPOSE 443

COPY *.csproj .

RUN dotnet restore

COPY . .

RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:7.0

WORKDIR /app

COPY --from=build /app/out .

ENTRYPOINT [ "dotnet", "FormulaOne.Api.dll" ]