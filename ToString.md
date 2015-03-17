# To String #

The ToString function converts the contents of a variable to a string.

Every VB data type has a ToString function.


Uses the form
```vb.net
VariableName.ToString()
```
The value in VariableName is converted to a string.

For example:
```vb.net
Dim intVal As Integer = 123           ' Assign an integer to a new variable'
lblNumber.text = intVal.ToString()    ' Converts integer 123 to string "123" '
                                      ' and assigns the string to the '
                                      ' text property of the lblNumber control'
```

# Format Strings #

The ToString function has an important feature missing from the
[CStr](TypeConversion#Explicit_Type_Conversion.md) function - the ability
to control the resulting appearance of the string.

For example:
```vb.net
Dim dblSample As Double
Dim strResult As String
dblSample = 1234.5
strResult = dblSample.ToString("c")
```
The value "c" is a _format string_

The format string applies currency format to the string "1234.5"
resulting in "$1,234.50"

### Types of format strings ###
| Format <br/> String | Description |
|:-----|:-----------------|
| **N** or **n** |  Number format. Includes commas and 2 decimal places by default |
| **D**  | Specify minimum number of integer digits. Will pad with zeros if needed |
| **F** or **f**  | Floating point format. Defaults to 2 decimal places. No commas in numbers |
| **E** or **e**  | Exponential format (scientific notation). Defaults to 1 decimal place. |
| **C** or **c**  | Currency format. Includes dollar sign and 2 decimal places |
| **P** or **p**  | Percent format. Multiplies value by 100 and appends " %" |

## Examples ##
```vb.net
Dim dblEuler As Double = 2.71828
Dim strVal As String
Dim intVal As Integer = 314159I

' No format string specified
strVal = dblEuler.ToString()        ' strVal = "2.71828"

strVal = dblEuler.ToString("N")     ' strVal = "2.72"
strVal = dblEuler.ToString("N4")    ' strVal = "2.7183"
strVal = intVal.ToString("N3")      ' strVal = "314,159.000"

strVal = dblEuler.ToString("D")     ' Throws a runtime exception: dblEuler is not an Integer
strVal = intVal.ToString("D")       ' strVal = "314159"

strVal = dblEuler.ToString("f")     ' strVal = "2.72"
strVal = dblEuler.ToString("f4")    ' strVal = "2.7183"
strVal = intVal.ToString("f1")      ' strVal = "314159.0"

strVal = dblEuler.ToString("e")     ' strVal = "2.718280e+000"
strVal = dblEuler.ToString("e4")    ' strVal = "2.7183e+000"
strVal = intVal.ToString("e3")      ' strVal = "3.142e+005"

' Currency formats
strVal = dblEuler.ToString("c")     ' strVal = "$2.72"
strVal = dblEuler.ToString("c1")    ' strVal = "$2.7"
strVal = intVal.ToString("c")       ' strVal = "$314,159.00"
strVal = intVal.ToString("c3")      ' strVal = "$314,159.000"

' Percentage formats
strVal = dblEuler.ToString("p")     ' strVal = "271.83 %"
strVal = dblEuler.ToString("p4")    ' strVal = "271.8280 %"
```

# Formatting Dates and Times #

When the ToString function is called on a Date object the ToString method<br>
can format the Date or DateTime value in a variety of ways.<br>
<br>
For example, if the date is 8/10/2010 and the time is 3:22 PM, then:<br>
<br>
<table><thead><th> <b>Format</b><br> String</th><th> <b>Description</b> </th><th> <b>ToString() Value</b> </th></thead><tbody>
<tr><td> <b>d</b>                  </td><td> Short Date    </td><td> "8/10/2010" </td></tr>
<tr><td> <b>D</b>                  </td><td> Long Date     </td><td> "Tuesday, August 10, 2010" </td></tr>
<tr><td> <b>t</b>                  </td><td> Short Time    </td><td> "3:22 PM" </td></tr>
<tr><td> <b>T</b>                  </td><td> Long Time     </td><td> "3:22:00 PM" </td></tr>
<tr><td> <b>F</b>                  </td><td> Long Date & Time     </td><td> "Tuesday, August 10, 2010 3:22:00 PM" </td></tr></tbody></table>



<h2>More to Explore</h2>
<ul><li><a href='https://msdn.microsoft.com/en-us/library/3hfd35ad(v=vs.110).aspx'>Double.ToString Method</a> from MSDN<br>
</li><li><a href='https://msdn.microsoft.com/en-us/library/zdtaw1bw(v=vs.110).aspx'>DateTime.ToString Method</a> from MSDN
