#! /usr/bin/env bash

until dotnet ef database update; do
>&2 echo "SQL Server is starting up"
sleep 1
done

dotnet FlagHunter.Api.dll