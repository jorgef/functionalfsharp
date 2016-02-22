let rec fibonacci = function
    | 0 -> 0
    | 1 -> 1
    | n -> fibonacci (n-1) + fibonacci (n-2)

let fibonacci' n = // tail recursive
    let rec loop i p c =
        match i with
        | 0 -> p
        | i -> loop (i-1) c (p+c) 
    loop n 0 1