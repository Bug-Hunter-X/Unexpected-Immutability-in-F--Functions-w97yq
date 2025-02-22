# Unexpected Immutability in F# Functions

This example demonstrates a common error in F# where developers unintentionally rely on the mutability of variables declared with `let`.  In F#, `let` bindings create immutable values by default.  To change this, you must use the `mutable` keyword.

## Problem

The `bug.fs` file contains code that attempts to modify variables declared with `let`.  Because these variables are implicitly immutable, the modification attempts are ignored, and the program does not produce the expected output.  Instead of modifying the variables, it's treating them as new variables that are declared but never used outside the function.

## Solution

The `bugSolution.fs` file provides a corrected version of the code. The `mutable` keyword is added to explicitly declare the variables `x` and `y` as mutable. This allows the values to change as intended. 

## How to Run

1.  Save the `bug.fs` and `bugSolution.fs` files.
2.  Compile and run each file using an F# compiler (e.g., `fsharpc bug.fs` and `fsharpc bugSolution.fs`). 

Observe the differences in the output to understand how the `mutable` keyword affects the behavior of variables in F# functions.