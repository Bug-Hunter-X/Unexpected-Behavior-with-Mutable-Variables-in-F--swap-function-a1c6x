# F# Mutable Variable Swap Bug

This example demonstrates a common error in F# involving mutable variables and unexpected behavior when using them in functions. The issue stems from the fact that mutable variables in F# are passed by reference, not by value.  This often leads to unexpected side effects.

## Bug Description
The `swap` function attempts to swap the values of two mutable variables, `x` and `y`.  However, due to pass-by-reference semantics, the original variables are modified directly, leading to the unintended modification of `x` and `y` outside the `swap` function's scope.

## Solution
To correct the behavior, the `swap` function should return a new tuple containing the swapped values. This ensures that the original variables remain unchanged, adhering to functional programming principles.