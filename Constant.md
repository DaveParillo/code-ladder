# Definition #

A _**constant**_ is a storage location in the computer memory,
used for holding information while the program is running.
The information that is stored in a constant **cannot change**, hence the name “constant”

## How to Think About Constants ##
  * You the programmer make up a name for the constant
  * Visual Basic associates that name with a location in the computer's RAM
  * The value associated with the constant is stored in that memory location

## Declaring Constants ##
A variable declaration is a statement that creates a variable in memory
The general syntax is:
```
Const VariableName As DataType = aValue
```
Where:
  * **Const** is a keyword
  * **VariableName** is the programmer designated name
  * **As** is a keyword
  * **DataType** tells the computer how much memory this variable requires
  * **aValue** is the literal value assigned to the constant

Unlike variables, where assigning a literal is optional,
it is required for constants.

Here are some examples of constant declarations:
```
Const intLength As Integer = 12I
Const sum As Long = 12345L
Const mileage As Single = 32.45S
Const totalCost As Decimal = 999.76D
Const radius As Double 55.46R
Const isFinished As Boolean = False
```

## Naming Rules ##
Constants have names that you, the programmer define.

Constants names are subject to some constraints:
  * Can contain letters, numbers and **(underscores)
  * Cannot start with a number
  * Nothing else is allowed
    * Spaces
    * Reserved words (If, Dim, As, New, Private)
    * Operators (_, +, -, .)_

These rules are exactly the same rules defined for [Variable](Variable.md)s.**


## More to Explore ##
  * [Constants video](https://www.youtube.com/watch?v=sSwTjALT26A) from [thenewboston](https://www.thenewboston.com/videos.php)



