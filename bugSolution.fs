let mutable x = 10
let mutable y = 20

let swap () =
    let temp = x
    x <- y
    y <- temp

swap ()
printf "%d %d" x y //this will print 20 10