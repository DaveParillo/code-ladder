# Implicit Type Conversion #

A value of one data type can be assigned to a variable of a different type.

An _implicit type conversion_ is an attempt to automatically convert to the receiving variable’s data type.
A _widening conversion_ suffers no loss of data.
  * Converting an integer to a double
```vb.net
Dim dblVal As Double = 5 ' implicit conversion during declaration

dblVal = -40             ' implicit conversion during assignment 
```

A narrowing conversion may lose data
  * Converting a decimal to an integer
```vb.net
Dim intNum As Integer = 12.2    ' intNum becomes 12
```

The OptionStrict configuration setting in Visual Basic restricts narrowing conversions.

# Explicit Type Conversion #

An _explicit type conversion_ is an attempt to convert one data type
to another using functions designed for type conversion.

The type conversion functions in all start with 'C' and the recieving data type.

| **Function** | **Definition** |
|:-------------|:---------------|
| CInt       | Convert numbers or strings to an integer |
| CStr       | Convert numbers to a string |
| CDec       | Convert numbers or strings to a decimal |
| CDate      | Convert a string to a date |


Other conversion functions:
  * CBool
  * CByte
  * CChar
  * CDbl
  * CLng
  * CObj
  * CShort
  * CSng

Some examples:
```vb.net
intVal = CInt(12.4)   ' intVal will round down to 12 
intVal = CInt(12.5)   ' intVal will round up to 13

strVal = CStr(26)     ' strVal will contain "26"

decPay = CDec("$1,534") ' removes the $ and , characters and stores 1534.0 

dateHired = CDate("2/14/2012")

' An example converting strings stored in Text properties
dblArea = CDbl(txtHeight.Text) * CDbl(txtWidth.Text)
```

## More to Explore ##
  * [Implicit and Explicit Conversions](https://msdn.microsoft.com/en-us/library/kca3w8x6(v=vs.90).aspx) from  Microsoft Developer Network
  * [Widening and Narrowing Conversions](https://msdn.microsoft.com/en-us/library/k1e94s7e(v=vs.90).aspx) from Microsoft Developer Network
