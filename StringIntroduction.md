# What is a String? #

The _**String**_ DataType represents a series, or list, of characters.
A string can contain from 0 to approximately two billion (2 ^ 31) Unicode characters.

Each character in the string is an instance of the _**Char**_ data type.
A character is an unsigned 16-bit (2-byte) _character code_ between 0 and 65535.
Each value, or character code, represents a single
[Unicode](http://unicode.org/standard/WhatIsUnicode.html) character.

The default value of String is Nothing (a null reference).
Note that this is not the same as the empty string (value "" or `String.Empty`).

## String Comparisons ##
Relational operators can be used to compare strings and string literals,
for example:
```vb.net
strName1 = "Alice"
strName2 = "Alfred"
If strName1 = strName2 Then
	lblMessage.Text = " Names are the same"
Else
	lblMessage.Text = " Names are NOT the same"
End If


If strMonth <> "October" Then
	' statement
End If
```

Strings are compared to each other _lexicographically_ - that is they
are compared as they would be ordered in the dictionary:

```vb.net
"Alfred" < "Alice"  ' This is True' 
"79" < "9"          ' This is also True'
```


## Empty Strings ##
An empty string is perfectly valid.
[An empty string is not \_Nothing\_](https://msdn.microsoft.com/en-us/library/ms233957.aspx).

The predefined constant String.Empty represents an empty string,
which is a string that contains no characters.

Useful for determining whether the user has provided input for
a required field before performing operations on that field.
For example:
```vb.net
If txtInput.Text = String.Empty Then
   lblMessage.Text = "Please enter a value"
Else
   ' The txtInput control contains something, so'
   ' perform an operation with it here.'
End If
```

## More to Explore ##
  * [What is Unicode?](http://unicode.org/standard/WhatIsUnicode.html) and [Unicode Charts Index](http://www.unicode.org/charts/index.html)
  * [String Basics](https://msdn.microsoft.com/en-us/library/ms234766.aspx) from MSDN
  * [String Functions list](https://msdn.microsoft.com/en-us/library/dd789093.aspx) from MSDN

