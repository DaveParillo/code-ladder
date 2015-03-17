# Putting variables to work #

Arithmetic operations allow us to combine variables and literals which can then be stored in a variable.

Arithmetic operators come in two flavors _unary_ and _binary_.
A _unary_ operator changes a single value, for example `-3` or `+foo`.
A _binary_ operator combines two values, for example `2 + 2`.

## Arithmetic Operators ##
These are the common operators we learned in grade school.

Common operators, listed in their order of precedence
| **Operator** | **Definition** |
|:-------------|:---------------|
| `^`        | Exponent.  Raises a base to a power, `base^power` = base<sup>power</sup> |
| `+, -`     | Unary negation or addition, `-5` |
| `*, /`     | Multiplication and division, `3 * 5`, `foo / 2` |
| `\`        | Integer division, `3 \ 5`, `rate \ intCount` |
| `MOD`      | Modulus.  The remainder of a division operation, `3 MOD 5` |
| `+, -`     | Addition and subtraction, `x + y`, `3 - 5` |

## Parentheses ##
The default order of operations can be overridden using parentheses.
In Visual Basic, expressions are always evaluated from left to right.
Operations within parentheses are evaluated first and the results within parentheses are then
evaluated within the rest of the expression.  FOr example:
```
Dim x as Double
Dim y as Double

x = 1 + 2 ^ 3
y = (1 + 2) ^ 3
```

In the example above, `2^3` is evaluated first, then 1 is added.  X = 9.
In the second line, `1+2` is evaluated first, then 3 is cubed `3^3`.  Y = 27.

## String Concatenation Operator ##
After all the arithmetic operators in precendence follows and operator used to combine two strings
into a single string.

| **Operator** | **Definition** |
|:-------------|:---------------|
| `&`        | String concatenation, "Hello " & "world!" |

## Combined operators ##

| **Operator** | **Example** | **Equivalet to** |
|:-------------|:------------|:-----------------|
| `+=`       | `x += 2`  | `x = x + 2`     |
| `-=`       | `x -= 5`  | `x = x - 5`     |
| `*=`       | `x *= 10` | `x = x * 10`    |
| `/=`       | `x /= 3`  | `x = x / 3`     |
| `\=`       | `x \= 6`  | `x = x \ 6`     |
| `&=`       | `x &= " Hello"`  | `x = x & " Hello"`     |



## More to Explore ##
  * [Arithmetic: Creating Expressions with Variables and Operators](https://msdn.microsoft.com/en-us/library/xbzhz001(v=vs.90).aspx) from Microsoft Developer Network
  * [Arithmetic Operators in Visual Basic](https://msdn.microsoft.com/en-us/library/b6ex274z(v=vs.90).aspx) from Microsoft Developer Network
  * [Math Operators video](https://www.youtube.com/watch?v=olCXCSIVzvk) from [thenewboston](https://www.thenewboston.com/videos.php)
  * [More on Math Operators video](https://www.youtube.com/watch?v=i0wq8415hxw) from [thenewboston](https://www.thenewboston.com/videos.php)
  * [Operators, Expressions and Statements video](http://channel9.msdn.com/series/Visual-Basic-Fundamentals-for-Absolute-Beginners/08) from [Channel 9 microsoftvirtualacademy.com](http://channel9.msdn.com/Series/Visual-Basic-Fundamentals-for-Absolute-Beginners)



