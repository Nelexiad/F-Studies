let isEven number =
    number % 2 = 0

let double number =
    number * 2

let describe numbers =
    numbers
    |> List.filter isEven
    |> List.map double
    |> List.sum

let values = [1; 2; 3; 4; 5; 6]

printfn "Values: %A" values
printfn "Result: %d" (describe values)

// Prova tu:
// 1. cambia il filtro per lavorare sui dispari
// 2. sostituisci double con triple
// 3. aggiungi un passaggio che ordina o tronca la lista
