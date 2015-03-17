# Mutually Exclusive Choices #
The **If…Then…Else…End If** provides two code blocks.

Just as in a normal IfThen statement, the **_condition_** will either be `True` or `False`,

Either the Then clause or Else clause will be executed, for example:
```
  Dim recommendation As String

  If airTemperature >= 45 Then
       ' our condition is true'
       recommendation = "Go outside an play."
  Else
       ' our condition is false'
       recommendation = "Go outside and play, but wear a jacket."
  End If
```

These are two mutually exclusive choices.
Once this code has finished executing, the string `recommendation` must contain one and only one
of the values defined.

## Many Choices ##
The `If…Then…ElseIf…[ElseIf]…Else…End If` provides many choices.
  * Each condition is tested in order – each is either `True` or `False`
  * Only 1 code block is executed – the rest are ignored
    * The first block that evaluates to `True` is executed.

```
  Dim recommendation As String

  If airTemperature > 95 Then
       recommendation = "Fix the air conditioner."
  ElseIf airTemperature > 65 Then
       recommendation = "Go outside and play."
  ElseIf airTemperature > 35 Then
       recommendation = "Go outside and play, but wear a coat."
  ElseIf airTemperature > 5 Then
       recommendation = "Build an igloo and wear your parka and mittens."
  Else
       ' this executes if every previous test fails    '
       ' the temperature must be <= 5  '
       recommendation = "Play inside."
  End If
```


## More to Explore ##
  * [Else And Else If video](https://www.youtube.com/watch?v=T-J2dSPanGE) from [thenewboston](https://www.thenewboston.com/videos.php)
  * [Nested If statements video](https://www.youtube.com/watch?v=PqGYLQPPZsA) from [thenewboston](https://www.thenewboston.com/videos.php)
  * [Branching with the If..Then..Else Decision Statement video](http://channel9.msdn.com/series/Visual-Basic-Fundamentals-for-Absolute-Beginners/07) from [Channel 9 microsoftvirtualacademy.com](http://channel9.msdn.com/Series/Visual-Basic-Fundamentals-for-Absolute-Beginners)
