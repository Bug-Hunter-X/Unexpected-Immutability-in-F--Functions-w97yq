let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printf "%d\n" z

//The issue is that the result is 30, not 30 and x and y are not mutated

x <- x + 1
y <- y + 1

printf "%d %d\n" x y