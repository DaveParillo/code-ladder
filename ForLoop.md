# Definiton #
A **For Loop** repeats a block of statements either
_**while**_ a _Boolean_ condition **is** _True_ or
_**until**_ the condition **becomes** _True_.

The **For...Next** loop performs the loop a set number of times.
It uses a loop control variable, also called a counter, to keep track of the repetitions.
You specify the starting and ending values for this counter,
and you can optionally specify the amount by which it increases from one repetition to the next.

# General Form #

```vb.net
For counter = start To end
    [ statements ]
Next
```

where:

| For | Required. Starts the definition of the For loop. |
|:----|:-------------------------------------------------|
| counter  | Required. A variable used to control the loop |
| start  | Required. The initial value of the counter |
| end  | Required. The final value of the counter |
| Next | Required. Terminates the definition of the For Each loop. |

There is no _posttest_ form for a **For Loop**.
For example:
```vb.net
Dim number As Double
Dim output As String

For number = 1 To 5
    output &= number.ToString & " "
Next

' output = "1 2 3 4 5 "

```

what works for a primitive DataType as above, works for controls as well:
```vb.net
Dim i As Integer
Dim txtBox As New TextBox

For i = 1 To 5
    txtBox.Text &= i.ToString & " "
Next

' txtBox.Text = "1 2 3 4 5 "
```


## Note ##
The _**To**_ keyword is used in this statement to specify the range for the counter.
We first encountered this in the SelectCase statement.


## Step Keyword ##
An optional _**Step**_ increment allows the counter to increment at a
value other than 1 each time though the loop.

For example:
```vb.net
Dim number As Double
Dim output As String

For number = 2 To 0 Step -0.25
    output &= number.ToString & " "
Next

' output = "2 1.75 1.5 1.25 1 0.75 0.5 0.25 0 "

```


# For Each Loop #
Designed to simplify looping on _**Collections**_,
the **For Each** loop repeats a group of statements for each member of
a _**Collection**_ or an _**enumerable**_ Object.

General form:
```vb.net
For Each element In group
    [ statements ]
Next [ element ]

```

where:

| For Each | Required. Starts the definition of the For Each loop. |
|:---------|:------------------------------------------------------|
| element | Required. Used to iterate through the elements of the collection.  It must be able to store objects of the type stored in the collection. |
| group | Required. A variable with a type that's a collection type or Object. Refers to the collection over which the statements are to be repeated. |
| Next | Required. Terminates the definition of the For Each loop. |

For example:
```vb.net
Dim ch As Char
Dim input As String = "The rain in Spain falls mainly on the plain"
Dim output As String

' A String can be viewed as a collection of characters
For Each ch In input
    output &= ch.ToString & ":"
Next

' output = "T:h:e: :r:a:i:n: :i:n: :S:p:a:i:n: :f:a:l:l:s: :m:a:i:n:l:y: :o::n: :t:h:e: :p:l:a:i:n:"

```


## Which Loop to Use? ##
Each type of loop works best in different situations

  * The Do While loop
    * When the desired number of iterations is unknown
    * When you wish the loop to repeat as long as the test expression is true or at least once as a pretest loop
  * The Do Until loop
    * When the desired number of iterations is unknown
    * When you wish the loop to repeat as long as the test expression is false or at least once as a pretest loop
  * The For…Next loop
    * Primarily used when the number of required iterations is known
  * The For Each…Next loop
    * Used you need to loop on each member of an object collection
    * When concepts like 'start' and 'stop' don't have clear definitions for your variables



## More to Explore ##
  * [Making a Program Repeat Actions: Looping with the For...Next Loop](https://msdn.microsoft.com/en-us/library/t12220k0(v=vs.90).aspx) from Microsoft Developer Network (MSDN)
  * [For Next video](https://www.youtube.com/watch?v=qRJGdPa9X24) from [thenewboston](https://www.thenewboston.com/videos.php)
  * [Step keyword video](https://www.youtube.com/watch?v=dO0V93u-0Kc) from [thenewboston](https://www.thenewboston.com/videos.php)
  * [For..Next Iterations video](http://channel9.msdn.com/series/Visual-Basic-Fundamentals-for-Absolute-Beginners/09) from [Channel 9 microsoftvirtualacademy.com](http://channel9.msdn.com/Series/Visual-Basic-Fundamentals-for-Absolute-Beginners)
  * [For Each loop video](https://www.youtube.com/watch?v=xAyjBq99ebE) from [thenewboston](https://www.thenewboston.com/videos.php)
