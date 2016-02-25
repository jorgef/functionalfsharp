type List<'a> =
    | Nil
    | Cons of 'a * List<'a> 

let setHead<'a> (head: 'a) (list: List<'a>) : List<'a> =
    Cons(head, list)

let t = Cons(1, Cons(2, Cons (3, Nil))) |> setHead 0