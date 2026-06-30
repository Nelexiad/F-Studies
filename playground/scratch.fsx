let numbers = [1; 2; 3; 4; 5]
let sum = List.sum numbers
let double x = x * 2
let triple x = x * 3
let half x = x / 2

let doubledNumbers = List.map double numbers
let tripledNumbers = List.map triple numbers
let halvedNumbers = List.map half numbers

printfn "Numbers: %A" numbers
printfn "Sum: %d" sum
printfn "Doubled: %A" doubledNumbers
printfn "Tripled: %A" tripledNumbers
printfn "Halved: %A" halvedNumbers

let name = "Daniele"
let surname = "D'Anna"
let buildStringForGreetings name surname =
    $"Ciao, {name} {surname}!"

printfn "%s" (buildStringForGreetings name surname)