# The TextAlign Property #

The TextAlign property defines how text is justified (aligned) within a control.  The TextAlign property can take one of nine values:

![http://wiki.code-ladder.googlecode.com/git/images/TextAlign.png](http://wiki.code-ladder.googlecode.com/git/images/TextAlign.png)

The default TextAlign depends upon the control type.  For example:

| **Control**   | **Default TextAlign** |
|:--------------|:----------------------|
| Label       | TopLeft      |
| Button      | MiddleCenter   |
| CheckBox    | MiddleLeft   |

Some controls, suchas as _Form_ controls, do not have a TextAlign property.

Note that the TextBox control has a TextAlign property, but it only takes 3 values:
  * Left
  * Center
  * Right

## Examples ##

  1. Setting the TextAlign property of a Label control named _lblCity_
```vb.net
     lblCity.TextAlign = ContentAlignment.TopLeft
```
  2. Retrieving the property
```vb.net
   Dim myAlign As ContentAlignment
   
   myAlign = lblCity.TextAlign
```
  3. Testing the property
```vb.net
   If myAlign = ContentAlignment.BottomRight Then
```

## More to Explore ##
  * [Label TextAlign Property](https://msdn.microsoft.com/en-us/library/system.windows.forms.label.textalign(v=vs.110).aspx) from MSDN


