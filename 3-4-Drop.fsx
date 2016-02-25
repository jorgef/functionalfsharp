type List<'a> =
    | Nil
    | Cons of 'a * List<'a> 

let rec drop<'a> (n: int) (list: List<'a>) : List<'a> =
    match n, list with
    | _, Nil -> Nil
    | 0, l -> l
    | n, Cons(_, t) -> drop (n - 1) t

let t = Cons(1, Cons(2, Cons (3, Nil))) |> drop 2