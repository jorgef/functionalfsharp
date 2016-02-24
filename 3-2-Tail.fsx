type List<'a> =
    | Nil
    | Cons of 'a * List<'a> 

let tail<'a> (list: List<'a>) : List<'a> =
    match list with
    | Nil -> Nil
    | Cons(_, tail) -> tail

let t = Cons(1, Cons(2, Cons (3, Nil))) |> tail