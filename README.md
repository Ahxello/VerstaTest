# Тестовое задание Верста
Используется база данных MSSQL, подключение производится к localhost базе данных VerstaTest.
Проверьте на наличие, чтобы избежать каких-либо конфликтов и возможной перезаписи таблиц.
### Строка подключения к БД:
```
"Data Source=localhost;Initial Catalog=VerstaTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
```
### После запуска проекта в консоле диспетчера пакетов обновите базу данных для применения миграций, используя команду:
```
Update-Database
```
