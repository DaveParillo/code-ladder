# Definiton #
A **Do Loop** repeats a block of statements either
_**while**_ a _Boolean_ condition **is** _True_ or
_**until**_ the condition **becomes** _True_.

Do loops come in two forms, depending on which keyword is used:
  * **While**  required unless **Until** is used.
    * Repeats as long as the condition is _True_
    * Ends when the condition becomes _False_
  * **Until**  required unless **While** is used.
    * Repeats as long as the condition is _False_
    * Ends when the condition becomes _True_

# General Form #
Both _**Do While**_ and _**Do Until**_ loops come in two forms, a _pretest form_
and a _posttest form_.


Pretest form:
```vb.net
Do { While | Until } condition
    [ statements ]
Loop
```

Posttest form:
```vb.net
Do
    [ statements ]
Loop { While | Until } condition
```


## Remarks ##

Use a Do...Loop structure when you want to repeat a set of statements
an indefinite number of times, until a condition is satisfied.
If you want to repeat the statements a set number of times,
the [ForLoop is usually a better choice.

You can use either _While_ or _Until_ to specify condition, but not both.

You can test your condition only one time,
at either the start or the end of the loop.

If you test condition at the start of the loop (in the Do statement),
the loop might not run even one time.

If you test at the end of the loop (in the Loop statement),
the loop always runs at least one time.

The condition usually results from a comparison of two values,
but it can be any expression that evaluates to a Boolean Data Type value (_True_ or _False_).
This includes values of other data types, such as numeric types, that have been converted to Boolean.

This treatment of condition is the same as in the [IfThen](IfThen.md) statement.

You can nest Do loops by putting one loop within another.
You can also nest different kinds of control structures within each other.
For more information, see [Nested Control Structures (Visual Basic)](https://msdn.microsoft.com/en-us/library/8y82wx12.aspx).

## Examples ##
Both of these examples produce the same output.
Neither is 'more correct' than the other.

  1. While loop using _pretest form_
```vb.net
Dim index As Integer 
Dim output As String
Do While index <= 10
    output &= index.ToString & " "
    index += 1
Loop 

' output = "0 1 2 3 4 5 6 7 8 9 10 "
```
  1. Until loop using _posttest form_
```vb.net
Dim index As Integer 
Dim output As String
Do
    output &= index.ToString & " "
    index += 1
Loop Until index > 10

' output = "0 1 2 3 4 5 6 7 8 9 10 "
```



## More to Explore ##
  * [Closer Look: Using Do...While and Do...Until to Repeat Until a Condition Is Met](https://msdn.microsoft.com/en-us/library/21daexkw(v=vs.90).aspx) from MSDN
  * [Do Until video](https://www.youtube.com/watch?v=v4WSyJKWLXY) from [thenewboston](https://www.thenewboston.com/videos.php)
  * [Do While video](https://www.youtube.com/watch?v=mdP5mQmAXwg) from [thenewboston](https://www.thenewboston.com/videos.php)
  * [More on Do loops video](https://www.youtube.com/watch?v=3ByynXMiJ2A) from [thenewboston](https://www.thenewboston.com/videos.php) - discussed the _postfix_ forms of an Until loop example.
  * [Nexted loops video](https://www.youtube.com/watch?v=jyp4ptojoh8) from [thenewboston](https://www.thenewboston.com/videos.php)

