let triple number =
    number * 3

let isEven number =
    number % 2 = 0

let average numbers =
    let total = numbers |> List.sum
    float total / float numbers.Length

let numbers = [2; 5; 8; 11; 14]
let language = "F#"

printfn "Language: %s" language
printfn "Numbers: %A" numbers
printfn "Triples: %A" (numbers |> List.map triple)
printfn "Even numbers: %A" (numbers |> List.filter isEven)
printfn "Sum: %d" (numbers |> List.sum)
printfn "Average: %.1f" (average numbers)

// Prova tu:
// 1. aggiungi una funzione square
// 2. crea una nuova lista e confronta i risultati
// 3. scrivi un messaggio finale con interpolazione
