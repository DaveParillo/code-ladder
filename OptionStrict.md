# Option Strict #
> Option Strict is a VB configuration setting

Implicit widening conversions are allowed when Option Strict is set to On
  * An integer can be assigned to a decimal
  * A single can be assigned to a double

Implicit narrowing conversions are not
  * A decimal cannot be assigned to an integer
  * A double cannot be assigned to a single

[Explicit type conversions](TypeConversion#Explicit_Type_Conversion.md) are always allowed.

Option Strict On is recommended to help catch errors
  * Type Conversion Runtime Errors
    * Dim intCount As Integer = "abc123”

Note that `Option Strict On` is the default setting in code ladder.

## More to Explore ##
  * TypeConversion
  * [Option Strict Statement](https://msdn.microsoft.com/en-us/library/zcd4xwzs(v=vs.90).aspx) from Microsoft Developer Network
