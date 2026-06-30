# 00 - Piano di studio

## Obiettivo

Usare questo repo per costruire una base pratica in F# attraverso:

- appunti brevi ma frequenti
- prove veloci in `.fsx`
- mini esercizi progressivi

## Cadenza consigliata

Obiettivo minimo: 4 sessioni a settimana da 30-45 minuti.

Struttura di ogni sessione:

1. 10 minuti di ripasso degli appunti precedenti
2. 10-15 minuti di nuovo concetto
3. 10-15 minuti di codice in `playground/` o `exercises/`
4. 5 minuti per scrivere cosa hai capito e cosa non ti e chiaro

## Piano di 8 settimane

### Settimana 1 - Sintassi di base

Focus:

- `let`
- valori immutabili
- tipi base
- `printfn`
- inferenza dei tipi

Output atteso:

- completare e ampliare `notes/01-valori-e-funzioni.md`
- modificare `playground/scratch.fsx` con 3 esempi personali
- completare `exercises/01-foundations/hello.fsx`

Mini esercizi:

1. scrivi `triple`, `isEven`, `toUpper`
2. calcola somma e media di una lista
3. stampa una frase con interpolazione

### Settimana 2 - Funzioni e pipeline

Focus:

- definire funzioni con uno o piu parametri
- pipeline `|>`
- composizione semplice
- differenza tra dati e trasformazioni

Output atteso:

- nuova nota su funzioni e pipeline
- uno script con catena di trasformazioni su una lista
- un esercizio con piccole funzioni riusabili

Mini esercizi:

1. dato un elenco di numeri, filtra i pari e raddoppiali
2. dato un elenco di nomi, normalizzali in maiuscolo
3. componi tre funzioni semplici in una pipeline

### Settimana 3 - Collezioni base

Focus:

- list
- tuple
- array
- operazioni frequenti: `map`, `filter`, `sum`, `length`

Output atteso:

- una nota con differenze tra list e array
- un esercizio su statistiche semplici da una collezione

Mini esercizi:

1. trova massimo e minimo di una lista
2. conta quanti elementi soddisfano una condizione
3. trasforma una lista di tuple in stringhe leggibili

### Settimana 4 - Record e discriminated unions

Focus:

- modelazione dei dati
- record immutabili
- union per stati o casi distinti

Output atteso:

- una nota con 2 modelli: `Person` e `OrderStatus`
- un esercizio che rappresenta uno stato applicativo semplice

Mini esercizi:

1. definisci un record `Book`
2. definisci una union `PaymentMethod`
3. crea una lista di record e filtrala per una proprieta

### Settimana 5 - Pattern matching

Focus:

- `match ... with`
- casi su numeri, tuple e union
- guardie `when`

Output atteso:

- espandere il progetto `first-console` con almeno un altro caso d'uso
- una nota che confronta `if` e `match`

Mini esercizi:

1. classifica un numero
2. descrivi il risultato di un login con una union
3. fai pattern matching su tuple coordinate `(x, y)`

### Settimana 6 - Option e Result

Focus:

- assenza di valore con `option`
- successo o errore con `result`
- evitare `null`

Output atteso:

- una nota con esempi di `Some`, `None`, `Ok`, `Error`
- un esercizio che valida input utente o dati simulati

Mini esercizi:

1. cerca un elemento in lista e ritorna `option`
2. valida una stringa numerica con `result`
3. concatena due validazioni semplici

### Settimana 7 - Moduli e organizzazione del codice

Focus:

- `module`
- separazione tra modello, logica e programma
- file multipli in un progetto F#

Output atteso:

- un mini progetto con almeno 2 file `.fs`
- una nota su come F# compila i file in ordine

Mini esercizi:

1. sposta le funzioni di utilita in un modulo dedicato
2. separa tipi e logica in file diversi
3. usa il modulo da `Program.fs`

### Settimana 8 - Consolidamento

Focus:

- ripasso
- refactoring
- piccoli problemi completi

Output atteso:

- scegliere 2 esercizi vecchi e riscriverli meglio
- creare un mini progetto finale a scelta

Idee progetto finale:

1. rubrica contatti in memoria
2. tracker di spese da console
3. todo list con record, union e pattern matching

## Definizione di completato

Una settimana e completata quando hai:

1. scritto almeno una nota nuova o aggiornato una nota esistente
2. eseguito almeno uno script `.fsx`
3. chiuso almeno un mini esercizio
4. annotato un dubbio tecnico da chiarire nella settimana successiva

## Regola pratica

Se un argomento ti blocca troppo, non fermarti a perfezionarlo subito:

1. scrivi un esempio minimo che funziona
2. annota il dubbio
3. passa all'esercizio piu piccolo possibile

L'obiettivo iniziale non e eleganza assoluta, ma costruire familiarita con il modo di pensare in F#.
