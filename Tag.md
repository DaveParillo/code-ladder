# The Tag Property #

The **Tag** property is used to store any arbitrary data you need to associate with a control.

In the Form Designer, only the String DataType can be assigned to a **Tag**,
but in code, any Object can be assigned.

All controls have a **Tag** Property.  The default value of the Tag property is _**Nothing**_.

A control with its visible property = False is still visible in the Visual Basic designer.

## Examples ##

Code examples:
  1. Setting the Tag property of a Label control named _lblCity_
> > `lblCity.Tag = "San Diego"`
  1. Retrieving the property
```
   Dim strTest As String
   
   strTest = lblCity.Tag                ' This example assumes the Tag contains a String. '
   strTest = lblCity.Tag.ToString  ' If unsure, this approach is safer.  '
```

## More to Explore ##
  * [Tag Property](https://msdn.microsoft.com/en-us/library/system.windows.forms.control.tag(v=vs.110).aspx) from Microsoft Developer Network