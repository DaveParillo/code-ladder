# Try-Catch Statements #

A well-engineered program should
  * Report errors and try to continue. Or,
  * Explain why it cannot continue, and then exit.

A common way of describing a runtime error is to say
_an exception was thrown_, and
_the exception was not handled_.

Or, one can refer to it as an _unhandled exception_.

Visual Basic provides an exception handler,
the Try-Catch statement:
```vb.net
Try
  ' Try block statements… '
  ' These statements might throw an exception '
  ' We want to _try_ to execute them '
Catch
  ' Catch block statements…'
  ' Statements to execute only if one the staements in the try'
  ' block fails and throws an exception'
End Try
```

Instead of a messy runtime failure, the _Catch block_ provides an
opportunity to address the problem.

For example:
```vb.net
Try
   ' Get the user''s input and convert it to a Decimal.'
   decSalary = CDec(txtSalary.Text)
   ' Display the user''s salary.'
   MessageBox.Show("Your salary is " & decSalary.ToString("c"))
Catch
   ' Display an error message.'
   MessageBox.Show( "Please try again, and enter a number.", _
                    "Input Error", _
                    MessageBoxButtons.OK,  _
                    MessageBoxIcon.Error)
End Try

```

If _CDec_ throws a cast exception, the _**try**_ block traps the error and then
the _**catch**_ block which displays the error message.

## Multiple Exceptions ##

It is possible to handle more than one type of exception.
Each exception can be handled in its own _Catch_ block.
For example:
```vb.net
Try
    Dim decAnnualSalaray, decSalary As Decimal
    Dim intPayPeriods As Integer

    decAnnualSalary = CDec(txtAnnualSalary.Text)
    intPayPeriods = CInt(txtPayPeriods.Text)
    decSalary = decAnnualSalary / intPayperiods
    lblSalary.Text = decSalary.ToString()

Catch ex As InvalidCastException
    MessageBox.Show(ex.Message, “Invalid number entered”, _
                    MessageBoxButtons.OK, _
                    MessageBoxIcon.Stop)

Catch ex As DivideByZeroException
    MesageBox.Show(“Pay periods cannot be zero”)
End Try
```


## More to Explore ##
  * [What To Do When Something Goes Wrong: Handling Errors](https://msdn.microsoft.com/en-us/library/betd08h8(v=vs.90).aspx) from MSDN
  * [Know Your Bugs: Three Kinds of Programming Errors](https://msdn.microsoft.com/en-us/library/s9ek7a19(v=vs.90).aspx) from MSDN
