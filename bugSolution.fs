let x = 1
let y = 2
let z = 3

let swap x y =
    (y, x)

let (x, y) = swap x y
printf "%d %d %d" x y z