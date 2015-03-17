# Logical Operators #

_Logical Operators_ allow us to combine Boolean variables and literals
which then returns a single composite boolean for the entire expression.

The Boolean operators, listed in order of precedence:
| **Operator** | **Effect** |
|:-------------|:-----------|
| **Not**      | Reverses the value of a Boolean |
| **And**      | Combines 2 expressions. If both are true, the entire expression is true. |
| **Or**       | Combines 2 expressions. If either is true, the entire expression is true. |
| **Xor**      | Combines 2 expressions. If one expression is true and the other false, then the entire expression is true. |

As in an ArithmeticOperation, parentheses are used to clarify and override the default order of operations.

## Boolean AND Operator ##
The **And** operator combines two expressions into one.
The following **If** statement uses the **And** operator:
```
If intTemperature < 20 And intMinutes > 12 Then
   lblMessage.Text = "It’s been cold too long."
End If
```

Both expressions must be true for the overall expression to be true, as shown in the following truth table:
| **X**     | **Y**     | **X And Y**  |
|:----------|:----------|:-------------|
| `True`  | `True`  | `True`     |
| `True`  | `False` | `False`    |
| `False` | `True`  | `False`    |
| `False` | `False` | `False`    |


## Boolean OR Operator ##
The **Or** operator combines two expressions into one.
The following **If** statement uses the **Or** operator:
```
If intTemperature < 20 Or intTemperature > 100 Then
   lblMessage.Text = "The temperature is out of control."
End If
```

If either expression is true, then the overall expression is true, as shown in the following truth table:
| **X**     | **Y**     | **X Or Y**   |
|:----------|:----------|:-------------|
| `True`  | `True`  | `True`     |
| `True`  | `False` | `True`     |
| `False` | `True`  | `True`     |
| `False` | `False` | `False`    |

## Boolean Not Operator ##
The Not operator takes a Boolean expression and reverses its logical value.

If the expression is `True`, the **Not** operator returns `False`, and if the expression is `False`, it returns `True`:
| **X**     | **Not X** |
|:----------|:----------|
| `True`  | `False` |
| `False` | `True`  |


## Boolean Xor Operator ##
The **Xor** operator combines two expressions into one.

If exactly one expression is true, then the overall expression is true, as shown in the following truth table:
| **X**     | **Y**     | **X Xor Y**   |
|:----------|:----------|:--------------|
| `True`  | `True`  | `False`     |
| `True`  | `False` | `True`     |
| `False` | `True`  | `True`     |
| `False` | `False` | `False`    |


## Boolean Short-Circuit Operators ##
Visual Basic includes two _short-circuit_ operators, **AndAlso** and **OrElse**.

When using the **And** operator, if the first expression is `False`,
then the entire expression will be `False`.

Similarly, when using the **Or** operator, if the first expression is `True`,
then the entire expression will be `True`.

If there is no need to evaluate the second expression,
it can be skipped using a method called short-circuit evaluation.


| **Operator** | **Effect** |
|:-------------|:-----------|
| **AndAlso**  | Evaluates the first expression.  If `False`, then **AndAlso** evaluates to `False`, otherwise the second expression is evalutated and the behavior is identical to **And** |
| **OrElse**   | Evaluates the first expression.  If `True`, then **OrElse** evaluates to `True`, otherwise the second expression is evaluated and the behavior is identical to **Or** |


## More to Explore ##
  * [Comparisons: Using Expressions to Compare Values](https://msdn.microsoft.com/en-us/library/hf71d2dk(v=vs.90).aspx) from Microsoft Developer Network (MSDN)
  * [Logical Operators video](https://www.youtube.com/watch?v=yjJ4yMk6D2U) from [thenewboston](https://www.thenewboston.com/videos.php)
  * [Boolean Expressions](https://msdn.microsoft.com/en-us/library/dya2szfk(v=vs.90).aspx) from MSDN




