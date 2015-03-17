# Definiton #

A TextBox is a control that allows users to input text.

The text displayed to the user is stored in the _Text_ property of the TextBox control.
The stored text can be used by other parts of your program.

For example, in the figure below, the text entered in the TextBox
is used to display "Hello, ", the text from the text box, plus an exclaimation point.

![http://wiki.code-ladder.googlecode.com/git/images/controlText.png](http://wiki.code-ladder.googlecode.com/git/images/controlText.png)

## Examples ##

  1. Storing a string in a TextBox named txtAddress
> > `txtAddress.Text = "123 State St. San Diego, CA 92110"`
  1. Retrieving a string from a TextBox named txtFullName
```
   Dim strName As String
   
   strName = txtFullName.Text
```
  1. Concatenate two strings and store the result
> > `txtResults.Text = "Hello, " & txtUserName.Text`

There are several ways to clear all the text stored in a TextBox:
  1. `txtInput.Clear() `
  1. `txtInput.Text = String.Empty`
  1. `txtInput.Text = ""`

Any of these approaches are acceptable, but I prefer #3 least.



## More to Explore ##
  * [TextBox Control](https://msdn.microsoft.com/en-us/library/sbxka1kb.aspx) from Microsoft Developer Network

