let product list = list |> List.fold (fun s v -> s * v) 1

let result = [1;2;3;4] |> product