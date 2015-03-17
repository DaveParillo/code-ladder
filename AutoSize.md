# The AutoSize Property #

The AutoSize property is a _**[Boolean](Boolean.md)**_ property of a Control.

If the AutoSize property = True, then the Control will automatically resize itself to fit its contents.

If the property = _False_ then the Control will not automatically change size. Items which do not fit are truncated.

## Examples ##

The AutoSize property of a Label Control causes a label to change size based on the amount of text stored in its _Text_ property.

If the value = _False_ then the label will not change size, regardless of how much text is stored in its _Text_ property.

Code examples:
  1. Setting the AutoSize property of a Label control named _lblCity_
> > `lblCity.AutoSize = False`
  1. Retrieving the property
```
   Dim blnTest As Boolean
   
   blnTest = lblCity.AutoSize
```


## More to Explore ##
  * [Label AutoSize Property](https://msdn.microsoft.com/en-us/library/system.windows.forms.label.autosize(v=vs.110).aspx) from MSDN

