let normalize (name: string) =
    name.Trim().ToUpper()

let longerThanThree (name: string) =
    name.Length > 3

let names = ["  ana"; "lu"; "  daniele  "; "fsharp"]

let cleanedNames =
    names
    |> List.map normalize
    |> List.filter longerThanThree

printfn "Original: %A" names
printfn "Cleaned: %A" cleanedNames

// Prova tu:
// 1. aggiungi un altro nome con spazi iniziali o finali
// 2. filtra con una regola diversa
// 3. crea una funzione che aggiunge un prefisso ai nomi puliti
