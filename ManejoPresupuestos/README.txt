
Instalar SQL Server en Docker con Mac
https://www.twilio.com/blog/using-sql-server-on-macos-with-docker

1. Instalar imagen sql server
docker run -d --name sql_server -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=someThingComplicated1234' -p 1433:1433 mcr.microsoft.com/mssql/server:2019-latest


