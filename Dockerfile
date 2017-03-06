FROM microsoft/dotnet:1.0.3-sdk-projectjson
COPY src /app
WORKDIR /app
 
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
ENV ASPNETCORE_URLS http://*:5000 
ENTRYPOINT ["dotnet", "run"]
