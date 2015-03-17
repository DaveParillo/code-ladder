# The Visible Property #

The Visible property is a _**[Boolean](Boolean.md)**_ property of a Control.

If the Visible property = True, then the Control will be visible at runtime.

If the property = _False_ then the Control will not be visible at runtime.

A control with its visible property = False is still visible in the Visual Basic designer.

## Examples ##

Code examples:
  1. Setting the Visible property of a Label control named _lblCity_
> > `lblCity.Visible = False`
  1. Retrieving the property
```
   Dim blnTest As Boolean
   
   blnTest = lblCity.Visible
```

## More to Explore ##
  * [Visible Property](https://msdn.microsoft.com/en-us/library/system.windows.forms.control.visible(v=vs.110).aspx) from Microsoft Developer Network

