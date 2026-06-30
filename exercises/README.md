# Exercises

Qui tieni esercizi piccoli, progressivi e possibilmente indipendenti.

Convenzione utile:

- una cartella per argomento
- uno script `.fsx` per prove rapide
- un mini progetto quando serve compilazione, file multipli o dipendenze

## Percorso iniziale consigliato

### Settimana 1 - Fondamentali

Cartella: `01-foundations/`

Ordine suggerito:

1. `hello.fsx`
2. `week-01-practice.fsx`
3. `first-console/`

Comandi:

```powershell
dotnet fsi .\exercises\01-foundations\hello.fsx
dotnet fsi .\exercises\01-foundations\week-01-practice.fsx
dotnet run --project .\exercises\01-foundations\first-console\FirstConsole.fsproj
```

### Settimana 2 - Funzioni e pipeline

Cartella: `02-functions-pipeline/`

Ordine suggerito:

1. `pipeline-basics.fsx`
2. `name-cleanup.fsx`

Comandi:

```powershell
dotnet fsi .\exercises\02-functions-pipeline\pipeline-basics.fsx
dotnet fsi .\exercises\02-functions-pipeline\name-cleanup.fsx
```
