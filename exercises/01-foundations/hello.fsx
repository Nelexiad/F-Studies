let greet name =
    $"Ciao, {name}!"

let double number =
    number * 2

let triple number =
    number * 3

let isEven number =
    number % 2 = 0

let average numbers =
    let total = numbers |> List.sum
    float total / float numbers.Length

let values = [1; 2; 3; 4]

printfn "%s" (greet "F#")
printfn "Doubles: %A" (values |> List.map double)
printfn "Triples: %A" (values |> List.map triple)
printfn "Even numbers: %A" (values |> List.filter isEven)
printfn "Sum: %d" (values |> List.sum)
printfn "Average: %.1f" (average values)

// Esercizi proposti:
// 1. cambia `greet` per ricevere nome e materia di studio
// 2. aggiungi una funzione `square` e confrontala con `double` e `triple`
// 3. prova a usare una lista diversa e prevedi l'output prima di eseguire

