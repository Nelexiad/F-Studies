let describeNumber number =
    match number with
    | n when n < 0 -> "negative"
    | 0 -> "zero"
    | 1 -> "one"
    | _ -> "many"

[-2; 0; 1; 4]
|> List.iter (fun number ->
    printfn "%d -> %s" number (describeNumber number)
)