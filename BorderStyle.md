# The BorderStyle Property #

The BorderStyle property defines the appearance of a border surrounding the control.  The BorderStyle property can take one of three values:
  * **None**.  No border is drawn around the control
  * **FixedSingle**.  A thin (1 pixel) border is drawn
  * **Fixed3D**.  A recessed border with a '3D' look

![http://wiki.code-ladder.googlecode.com/git/images/BorderStyle.png](http://wiki.code-ladder.googlecode.com/git/images/BorderStyle.png)

The default BorderStyle depends upon the control type.  For example:
| **Control**   | **Default BorderStyle** |
|:--------------|:------------------------|
| Label       | None      |
| TextBox     | Fixed3D   |

Some controls, suchas as _Button_ controls, do not have a BorderStyle property.

## Examples ##

  1. Setting the BorderStyle property of a Label control named _lblCity_
> > `lblCity.BorderStyle = BorderStyle.FixedSingle`
  1. Retrieving the property
```
   Dim myStyle As BorderStyle
   
   myStyle = lblCity.BorderStyle
```
  1. Testing the property
```
   If myStyle = BorderStyle.Fixed3D Then
```

## More to Explore ##
  * [Label BorderStyle Property](https://msdn.microsoft.com/en-us/library/system.windows.forms.label.borderstyle(v=vs.110).aspx) from MSDN
