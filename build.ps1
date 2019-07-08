﻿Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/ocr -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js


(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj).replace('<Authors>Swagger</Authors>', "<Authors>Cloudmersive</Authors>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj).replace('<Company>Swagger</Company>', "<Company>Cloudmersive</Company>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj).replace('<AssemblyTitle>Swagger Library</AssemblyTitle>', "<AssemblyTitle>Cloudmersive OCR API Client</AssemblyTitle>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj).replace('<Description>A library generated from a Swagger doc</Description>', "<Description>The powerful Optical Character Recognition (OCR) APIs let you convert scanned images of pages into recognized text.</Description>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj).replace('<TargetFramework>net45</TargetFramework>', "<TargetFramework>netcoreapp2.1</TargetFramework>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj).replace('</PropertyGroup>', "<PackageIconUrl>https://cloudmersive.com/images/cmsdk_core.png</PackageIconUrl><PackageLicenseExpression>Apache-2.0</PackageLicenseExpression></PropertyGroup>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj
(Get-Content '.\client\src\Cloudmersive.APIClient.NETCore.OCR\Client\Configuration.cs').replace('Timeout = 100000;', "Timeout = 900000;") | Set-Content '.\client\src\Cloudmersive.APIClient.NETCore.OCR\Client\Configuration.cs'



#& npm build ./client
& dotnet build ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj -c Release
& dotnet pack ./client/src/Cloudmersive.APIClient.NETCore.OCR/Cloudmersive.APIClient.NETCore.OCR.csproj -c Release

(Get-Content ./client/README.md).replace(' automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project', " for the [Cloudmersive OCR API](https://www.cloudmersive.com/ocr-api)") | Set-Content ./client/README.md

Copy-Item ./client/README.md ./README.md