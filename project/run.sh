#!/usr/bin/env bash

yarn install
rm -rf ./generated/csharp
yarn openapi-generator-cli generate --config OpenApi/config-csharp.json
dotnet run