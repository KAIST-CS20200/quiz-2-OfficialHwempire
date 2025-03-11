module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let iseven n = 
    if n % 2UL = 0UL then true
    else false
  let rec result count x =
    if x=1UL then count
    else 
    if iseven x then result (count+1) (x/2UL)
    else result (count+1) (3UL*x+1UL)
  printfn "Collatz conjecture for %d" n
  result 0 (uint64 n)
