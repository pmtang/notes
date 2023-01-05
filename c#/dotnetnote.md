### 1. check installed sdks or runtimes
dotnet --list-sdks
dotnet --list-runtimes

### 2. Publish
(e.g. wpf)To publish in a single file:  
dotnet publish -c Release -r win-x64 -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true