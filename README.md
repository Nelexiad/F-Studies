# F-Studies

Repo personale per studiare F# con due binari paralleli:

- appunti brevi e incrementali
- esercizi piccoli e subito eseguibili

## Struttura

```text
notes/        appunti di studio
playground/   script .fsx per prove veloci
exercises/    esercizi e mini progetti
```

## Come usare questo repo

### 1. Prendere appunti

Usa `notes/` per fissare concetti, sintassi, dubbi e piccoli esempi.

### 2. Provare codice al volo

Usa `playground/scratch.fsx` per test rapidi senza creare un progetto.

Lo script e gia impostato con esempi utili per Settimana 1 e Settimana 2.

Esegui con:

```powershell
dotnet fsi .\playground\scratch.fsx
```

### 3. Fare esercizi

In `exercises/` trovi sia script sia un primo progetto console F#.

Esegui lo script base con:

```powershell
dotnet fsi .\exercises\01-foundations\hello.fsx
```

Esegui il progetto console con:

```powershell
dotnet run --project .\exercises\01-foundations\first-console\FirstConsole.fsproj
```

## Percorso suggerito

1. Valori immutabili, `let`, tipi base
2. Funzioni e pipeline `|>`
3. Liste, tuple, record e discriminated unions
4. Pattern matching
5. Moduli e organizzazione del codice
6. Async, Result, Option e gestione errori

Piano di studio dettagliato: `notes/00-piano-di-studio.md`

Note iniziali consigliate:

- `notes/01-valori-e-funzioni.md`
- `notes/02-funzioni-e-pipeline.md`

## Routine pratica consigliata

Per ogni argomento:

1. scrivi 5-10 righe di appunti in `notes/`
2. prova un esempio in `playground/scratch.fsx`
3. chiudi con un mini esercizio in `exercises/`

## Tooling già disponibile

Nel tuo ambiente `dotnet` è già installato, quindi puoi iniziare subito con F#.

Se vuoi migliorare l'esperienza in VS Code, l'estensione più utile è Ionide per F#.
