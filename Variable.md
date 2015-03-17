# Why Have Variables? #

A _**variable**_ is a storage location in the computer memory,
used for holding information while the program is running.
The information that is stored in a variable may change, hence the name “variable”

## How to Think About Variables ##
  * You the programmer make up a name for the variable
  * Visual Basic associates that name with a location in the computer's RAM
  * The value currently associated with the variable is stored in that memory location

## Declaring Variables ##
A variable declaration is a statement that creates a variable in memory
The general syntax is:
```vb.net
Dim VariableName As DataType
```
Where:
  * **Dim** (short for Dimension) is a keyword
  * **VariableName** is the programmer designated name
  * **As** is a keyword
  * **DataType** tells the computer how much memory this variable requires

Here are some examples of a variable declarations:
```vb.net
Dim intLength As Integer
Dim sum As Long
Dim mileage As Single
Dim totalCost As Decimal
Dim radius As Double
Dim isFinished As Boolean
```

## Variable Naming Rules ##
Variables have names that you, the programmer define.

Variable names are subject to some constraints:
  * Can contain letters, numbers and **(underscores)
  * Cannot start with a number
  * Nothing else is allowed
    * Spaces
    * Reserved words (If, Dim, As, New, Private)
    * Operators (`*, +, -, .`)

## Variable Naming Conventions ##
In Visual Basic, it's common to use a prefix as part of the variable name.
This is especially common for [Controls](Controls.md), but can be used for any variable.

Typocal prefix notion used for controls:

| **Control**    | **Prefix** | **Example**  |
|:---------------|:-----------|:-------------|
| Form         | frm      | frmMain    |
| Label        | lbl      | lblResults |
| TextBox     | txt      | txtInput   |
| Button       | btn      | btnClose   |
| CheckBox    | chk      | chkRefund  |
| RadioButton | rad      | radSenior  |

You may also see prefixes applied to primitive a DataType as well.
Typical prefix notion used for controls:

| **Type**       | **Prefix** | **Example**  |
|:---------------|:-----------|:-------------|
| Boolean      | bln      | blnReturn  |
| Integer      | int      | intCount   |
| Single       | sng      | sngMiles   |
| Double       | dbl      | dblRate    |
| String       | str      | strName    |


## More to Explore ##
  * [Representing Words, Numbers, and Values with Variables](https://msdn.microsoft.com/en-us/library/9kc1d337(v=vs.90).aspx) from Microsoft Developer Network
  * [Variables video](https://www.youtube.com/watch?v=r8GHJyFOP18) from thenewboston
  * [Declaring Variables and Assigning Values video](http://channel9.msdn.com/Series/Visual-Basic-Fundamentals-for-Absolute-Beginners/06) from [Channel 9 microsoftvirtualacademy.com](http://channel9.msdn.com/Series/Visual-Basic-Fundamentals-for-Absolute-Beginners)

