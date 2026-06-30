# 01 - Valori e funzioni

## Obiettivo della settimana

Capire la sintassi minima di F# e prendere confidenza con il flusso:

1. scrivo una funzione
2. la provo su una lista
3. osservo il risultato in output

## Idee chiave

- `let` definisce valori e funzioni
- i valori sono immutabili di default
- le funzioni si compongono bene con la pipeline `|>`

## Esempi

```fsharp
let name = "Daniele"
let double x = x * 2

let result =
    [1; 2; 3]
    |> List.map double
```

## Esempi guidati

```fsharp
let triple x = x * 3
let isEven x = x % 2 = 0

let numbers = [1; 2; 3; 4; 5; 6]

let doubled = numbers |> List.map double
let evens = numbers |> List.filter isEven
let total = numbers |> List.sum
```

```fsharp
let shout text = text.ToUpper()
let subject = shout "f#"
let message = $"Sto studiando {subject}"
```

## Cose da ricordare

- in F# spesso il tipo viene inferito
- le parentesi si usano meno che in C#
- l'indentazione conta molto per la leggibilita

## Esercizi guidati

1. Aggiungi una funzione `triple` e applicala a una lista di numeri.
2. Scrivi `isEven` e usala con `List.filter`.
3. Crea una funzione `greet` che riceve un nome e ritorna una stringa interpolata.
4. Calcola somma e media di una lista di interi.

## Checklist Settimana 1

Per considerare chiusa questa settimana:

1. sai leggere e scrivere una funzione semplice con `let`
2. sai usare `List.map`, `List.filter` e `List.sum`
3. sai stampare risultati con `printfn`
4. hai almeno un dubbio annotato da chiarire

## Domande aperte

- quando conviene annotare il tipo in modo esplicito?
- come cambia il design rispetto a un approccio object-oriented?

## Prossimo passo

Passa a `notes/02-funzioni-e-pipeline.md` quando ti senti a tuo agio con:

- funzioni di una riga
- trasformazioni su liste
- output leggibile da console
