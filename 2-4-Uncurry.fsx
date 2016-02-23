let uncurry<'a,'b,'c> (f: 'a -> 'b -> 'c) : ('a * 'b) -> 'c =
    fun (a, b) -> f a b
