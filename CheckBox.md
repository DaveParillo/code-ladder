# Definiton #

A Check Box is a control that allows users to select any of several possible options.
Each option is displayed as a separate button with a square indicator to the left.

Check Boxes may be placed in a _Group Box_ control.
It does not change the behavior of how Check Boxes are selected.

Check Boxes have a Boolean _**Checked**_ property and a _**CheckedChanged**_ event.

## Example ##
Testing the value of the _**Checked**_ property:
```
Dim discount As Decimal

If chkApplyDiscount.Checked Then
    discount = 0.025d
Else
    discount = 0.0d
End If

```



## More to Explore ##
  * [CheckBox Control](https://msdn.microsoft.com/en-us/library/dzddyc7z.aspx) from Microsoft Developer Network


