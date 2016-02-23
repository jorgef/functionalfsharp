let compose<'a,'b,'c> (f: 'b -> 'c) (g: 'a -> 'b) : 'a -> 'c =
    fun a -> 
        let b = g a
        f b