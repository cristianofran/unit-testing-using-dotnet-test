## Coletar cobertura de código e gera logger
dotnet test --logger trx --collect:"XPlat Code Coverage"

## Gerar relatórios
reportgenerator -reports:"TestResults\b1556951-024b-4202-9181-2b1c6cdd0070\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
