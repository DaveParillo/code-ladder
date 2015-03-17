# Definiton #
Usually a conditional expression is formed using a _relational operator_.

A relational operator determines if a specific relationship exists between two values:
| **Operator** | **Definition** |
|:-------------|:---------------|
|  `>`       | Greater than    |
|  `<`       | Less than    |
|  `=`       | Equal to    |
|  `<>`      | Not equal to    |
|  `>=`      | Greater than or equal to    |
|  `<=`      | Less than or equal to    |

## Boolean Expressions ##
A _boolean expression_ is a condition that includes one or more relational or logical operators.
It _always_ returns a _Boolean_: `True` or `False`, for example:

| **Boolean Expression**    | **English Expression** |
|:--------------------------|:-----------------------|
|  `length > width`       | is the length greater then the width? |
|  `size <= 10`           | is the size less than or equal to 10? |


## Examples ##

```
  If decSales > 50000 Then
     MessageBox.Show("You earned a bonus!")
  End If
```


```
  If airTemperature < 48 Then
     intCount += 1
     MessageBox.Show("You should wear a jacket.")
     ' do anything else we thing is appropriate'
  End If
```

## More to Explore ##

  * [Conditional operators video](https://www.youtube.com/watch?v=DavAWs79c9w) from [thenewboston](https://www.thenewboston.com/videos.php)