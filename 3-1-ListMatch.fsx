let x = 
    match [1;2;3;4;5] with
    | x :: 2 :: 4 :: _ -> x
    | [] -> 42
    | x :: y :: 3 :: 4 :: _ -> x + y
    | h :: t -> h + (t |> List.sum)
    | _ -> 101