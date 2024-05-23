ARG PARENT_VERSION=dotnet8.0

# Development
FROM defradigital/dotnetcore-development:${PARENT_VERSION} AS development
ARG PARENT_VERSION
LABEL uk.gov.defra.ffc.parent-image=defradigital/dotnetcore-development:${PARENT_VERSION}

COPY --chown=dotnet:dotnet ./src/Directory.Build.props ./Directory.Build.props
RUN mkdir -p /home/dotnet/ncea-mapper/ /home/dotnet/ncea-mapper.tests/
COPY --chown=dotnet:dotnet ./src/ncea-mapper.tests/*.csproj ./ncea-mapper.tests/
RUN dotnet restore ./ncea-mapper.tests/ncea-mapper.tests.csproj
COPY --chown=dotnet:dotnet ./src/ncea-mapper/*.csproj ./ncea-mapper/
RUN dotnet restore ./ncea-mapper/ncea-mapper.csproj
COPY --chown=dotnet:dotnet ./src/ncea-mapper.tests/ ./ncea-mapper.tests/
# some CI builds fail with back to back COPY statements, eg Azure DevOps
RUN true
COPY --chown=dotnet:dotnet ./src/ncea-mapper/ ./ncea-mapper/
RUN dotnet publish ./ncea-mapper/ -c Release -o /home/dotnet/out

ARG PORT=8080
ENV PORT ${PORT}
EXPOSE ${PORT}
# Override entrypoint using shell form so that environment variables are picked up
ENTRYPOINT dotnet watch --project ./ncea-mapper run --urls "http://*:${PORT}"

# Production
FROM defradigital/dotnetcore:${PARENT_VERSION} AS production
ARG PARENT_VERSION
LABEL uk.gov.defra.ffc.parent-image=defradigital/dotnetcore:${PARENT_VERSION}
COPY --from=development /home/dotnet/out/ ./
ARG PORT=8080
ENV ASPNETCORE_URLS http://*:${PORT}
EXPOSE ${PORT}
# Override entrypoint using shell form so that environment variables are picked up
ENTRYPOINT dotnet ncea-mapper.dll
