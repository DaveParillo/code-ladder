# String Replace #

The Replace function returns a new string
in which all occurrences of a specified String
in the first argument are replaced with another specified String.

This method does not modify the value of the current instance.
Instead, it returns a new string in which all occurrences of oldValue are replaced by newValue.

General Form:
```vb.net
StringExpression.Replace
         (searchFor, replaceWith)
```
Replaces each searchFor character or string found with the replaceWith character or string.

and
```vb.net
StringExpression.Replace
         (searchFor, replaceWith, maxTimes)
```
Replaces each searchFor character or string found with the replaceWith character or string, but only maxTimes.

Note that `searchFor` and `replaceWith` must both be the same DataType.
That is they must both be of type Char or of type String.
You can't mix types.


For example:
```vb.net
Dim strResult As String
Dim myString = "Peter Piper picked a peck of pickled peppers."

strResult = myString.Replace("ck", " CK ")
' strResult =  "Peter Piper pi CK ed a pe CK  of pi CK led peppers."

strResult = myString.Replace("ck", " CK ", 1)
' strResult =  "Peter Piper pi CK ed a peck of pickled peppers."
```


You can also call replace as a standalone function, passing in the String as the first argument:
```vb.net
' Replace each occurrence of a character 'n' in a String with Nothing.
Dim Phrase As String = "The rain in Spain falls mainly on the plain."
Dim ch as Char = "n"c
Dim s As String

s = Replace (Phrase, ch, Nothing)
' s = "The rai i Spai falls maily on the plai."
```
This version is more flexible about types passed to it, but it's slower.


## More to Explore ##
  * [String.Replace Method](https://msdn.microsoft.com/en-us/library/vstudio/fk49wtc1(v=vs.110).aspx) from MSDN
  * [String Methods](https://msdn.microsoft.com/en-us/library/vstudio/System.String_methods(v=vs.100).aspx) from MSDN


