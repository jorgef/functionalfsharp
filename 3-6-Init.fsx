type List<'a> =
    | Nil
    | Cons of 'a * List<'a> 

let init<'a> (list: List<'a> ) : List<'a> =
    let rec reverse res list =
        match list with
        | Nil -> res
        | Cons(h, t) -> reverse (Cons(h, res)) t
        
    let rec loop res list =
        match list with
        | Nil -> Nil
        | Cons(_, Nil) -> reverse Nil res
        | Cons(h, t) -> loop (Cons(h, res)) t

    loop Nil list

let t = Cons(1, Cons(2, Cons (3, Nil))) |> init