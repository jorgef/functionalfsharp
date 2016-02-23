let curry<'a,'b,'c> (f: ('a * 'b) -> 'c) : 'a -> ('b -> 'c) =
    fun (a: 'a) ->
        fun (b: 'b) -> f (a, b)