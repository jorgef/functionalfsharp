let rec isSorted<'a> (ordered: ('a * 'a) -> bool) (array: 'a[]) : bool =
    match (array |> Array.tryHead, array |> Array.tryItem 1) with
    | _, None | None, _ -> true
    | Some f, Some s when ordered (f,s) -> array |> Array.tail |> isSorted ordered
    | _ -> false