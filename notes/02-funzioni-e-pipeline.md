# 02 - Funzioni e pipeline

## Obiettivo della settimana

Capire come trattare le funzioni come trasformazioni piccole e comporre passaggi leggibili su dati semplici.

## Idee chiave

- una funzione prende un input e produce un output
- la pipeline `|>` passa il risultato di sinistra alla funzione a destra
- in F# spesso scrivi molti passaggi piccoli invece di una funzione grande

## Sintassi minima

```fsharp
let addOne x = x + 1
let double x = x * 2

let result =
    3
    |> addOne
    |> double
```

## Esempio su lista

```fsharp
let isEven x = x % 2 = 0
let double x = x * 2

let values = [1; 2; 3; 4; 5; 6]

let transformed =
    values
    |> List.filter isEven
    |> List.map double
```

## Come leggere una pipeline

Questa pipeline:

```fsharp
values
|> List.filter isEven
|> List.map double
|> List.sum
```

si legge cosi:

1. prendi `values`
2. tieni solo i pari
3. raddoppia ogni elemento
4. somma il risultato

## Quando e utile

- quando vuoi rendere espliciti i passaggi
- quando puoi riusare funzioni piccole
- quando stai trasformando liste o altri dati in sequenza

## Errori comuni all'inizio

- mescolare troppa logica dentro una singola lambda
- perdere il filo del tipo che esce da ogni passaggio
- usare la pipeline anche quando una chiamata diretta e piu chiara

## Esercizi guidati

1. Prendi una lista di numeri, filtra i dispari e moltiplicali per 10.
2. Prendi una lista di nomi e trasformala in maiuscolo.
3. Scrivi tre funzioni piccole e collegale con `|>`.

## Checklist Settimana 2

1. sai spiegare cosa entra e cosa esce da ogni funzione
2. sai leggere una pipeline dall'alto verso il basso
3. sai usare `List.filter` e `List.map` nello stesso flusso
4. sai estrarre almeno una funzione invece di scrivere tutto inline

## Domande aperte

- quando usare una funzione nominata invece di una lambda?
- quando la pipeline migliora davvero la leggibilita?
