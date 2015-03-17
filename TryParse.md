# TryParse Functions #
Like the TypeConversion techniques we have already learned,
the TryParse function converts a string to a number.

Each numeric DataType has a TryParse function.
The general format is:
```vb.net
DataType.TryParse ( String, numericVariable )
```

TryParse will try to parse the string as the provided DataType.
If successful, TryParse will store the number in the variable
provided.

The numeric variable must be of the same type as the DataType used.

Syntax examples:
```vb.net
Integer.TryParse (txtInput.Text, intResult)
Decimal.TryParse (txtInput.Text, decCost)
Double.TryParse (txtInput.Text, dblMileage)
```

The String can be anything that evaluates to a String:
  * A variable of type _String_
  * A _Text_ Property
  * A string literal
  * A function which returns a string

So far, TryParse is not very different from the TypeConversion
functions, but TryParse does one more valuable thing.
If the TryParse operation succeeds, then the function
returns `True`, otherwise it returns `False`.
This allows for more than the basic ExceptionHandling we have
already covered.  It allows for _input validation_.

## Example ##

```vb.net
Dim height As Double
Dim length As Double = 10
Dim area As Double

If Double.TryParse (txtHeight.Text, height) Then
    ' we know it is safe to use the variable height 
    ' it at least stores a valid double although we do not know if it is <= 0 
    area = length * height
Else
    MessageBox.Show ("Please enter height as a number.")
End If
```

## More to Explore ##
  * [Single.TryParse Method](https://msdn.microsoft.com/en-us/library/26sxas5t(v=vs.110).aspx) from MSDN
  * [Parsing Numeric Strings in the .NET Framework](https://msdn.microsoft.com/en-us/library/xbtzcc4w(v=vs.110).aspx) from MSDN
