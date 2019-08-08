FROM microsoft/dotnet:2.2.0-aspnetcore-runtime AS base

WORKDIR /app
COPY .publish/W /app

ENTRYPOINT ["dotnet", "IssueML.dll"]