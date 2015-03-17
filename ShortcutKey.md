# Definiton #

It is possible to bind any button to the `<Alt>` key + a letter.
In the _Text_ property of the button control, type an ampersand character, &
just before the letter you want to define as your shortcut.

The '&' is not displayed, but instead the shortcut character is underlined

For Example, to use the letter 'x' as the shortbut character in a button with
its _Text_ property = 'Exit' change the _Text_ property to 'E&xit'

Just be sure you don't define the same shortcut key for two different buttons.

## Examples ##

  1. Setting the shortcut to 'x' on an Exit button
> > `btnExit.Text = "E&xit"`
