let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + 1
    y <- y + 1
    x + y

let z = add x y

printf "%d\n" z

printf "%d %d\n" x y