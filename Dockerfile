FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /TaskForNis

COPY . ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /ProjectForNis
COPY --from=build /ProjectForNis/out .
ENTRYPOINT ["dotnet", "ProjectForNis.dll"]
