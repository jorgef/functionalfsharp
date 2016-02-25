type List<'a> =
    | Nil
    | Cons of 'a * List<'a> 

let rec dropWhile<'a> (f: 'a -> bool) (l: List<'a>) : List<'a> =
    match l with
    | Nil -> Nil
    | Cons(a, _) when not (f a) -> l
    | Cons(_, t) -> dropWhile f t

let t = Cons(1, Cons(2, Cons (3, Nil))) |> dropWhile (fun a -> a < 2)