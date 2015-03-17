# Definiton #
A Select ... Case statement conditionally executes code blocks,
just as the [IfThen](IfThen.md) and [IfThenElse](IfThenElse.md) statements do.

Select Case is different in that:
  * A single test expression may be evaluated
  * The test expression is listed once
  * The possible values of the expression are then listed with their conditional statements


`Case Else` may be included and executed if none of the values match the expression.

## Example ##
```
Dim dblAvg As Double = 85.23
Dim strLetterGrade As String

Select Case dblAvg 
    Case Is > 90
        strLetterGrade = "A"
    Case Is > 80
        strLetterGrade = "B"
    Case Is > 70
        strLetterGrade = "C"
    Case Is > 60
        strLetterGrade = "D"
    Case Else
        strLetterGrade = "F"
End Select
```


## More to Explore ##
  * [Using Select Case to Decide Between Multiple Choices](https://msdn.microsoft.com/en-us/library/2h66e7a8(v=vs.90).aspx) from Microsoft Developer Network
  * [Select Case video](https://www.youtube.com/watch?v=3wvvD4Vfr4k) from [thenewboston](https://www.thenewboston.com/videos.php)
  * [Case Else video](https://www.youtube.com/watch?v=o-LmyPNgY-o) from [thenewboston](https://www.thenewboston.com/videos.php)


