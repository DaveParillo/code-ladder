# Message Box #

A MessageBox displays a message in a small popup window or dialog box,
waits for the user to click a button, and then
returns a value indicating which button the user clicked.

Use a MessageBox to provide instructions to the user or to request information.

The only way to display a MessageBox to the user is by writing code.
You can't make a MessageBox appear in the designer.
For example, `MessageBox.Show ("Hello, World!")` displays the simple window shown below.

![http://wiki.code-ladder.googlecode.com/git/images/helloWorld.png](http://wiki.code-ladder.googlecode.com/git/images/helloWorld.png)

A MessageBox is an object with a function named _Show_.
The significance of each part of this statement is:

| `MessageBox` | `.` (dot) | `Show` | `(` | `"Hello World!"` | `)` |
|:-------------|:----------|:-------|:----|:-----------------|:----|
| Name of Object | separator | Name of function | start function arguments | String argument | end function arguments |

This is the simplest way to define a MessageBox, but it's kind of boring.
It only defines the actual message text, which is required.
There are other optional parameters which can be passed to the _Show_ function:
  * **Text** - the message to display within the window
  * **Caption** - text to display in the window title bar
  * **Buttons** - indicates which buttons to display in the window
  * **Icon** - an icon to display next to the message
  * **Default Button** - define which button will activate when the _Enter_ key is pressed

## Buttons ##
The buttons argument is optional.
Unless specified, a MessageBox has only an _OK_ button.

The buttons parameter must equal one of the allowed types:
| **Value**                               | **Description** |
|:----------------------------------------|:----------------|
| MessageBoxButtons.AbortRetryIgnore    | Displays _Abort_, _Retry_, & _Ignore_   |
| MessageBoxButtons.OK                  | Displays _OK_ only   |
| MessageBoxButtons.OKCancel            | Displays _OK_ & _Cancel_   |
| MessageBoxButtons.RetryCancel         | Displays _Retry_ & _Cancel_   |
| MessageBoxButtons.YesNo               | Displays _Yes_ & _No_ |
| MessageBoxButtons.YesNoCancel         | Displays _Yes_, _No_, & _Cancel_ |


## Icon ##
The icon argument is optional.
Unless specified, a MessageBox has no icon.

The icon parameter must equal one of the allowed types:
| **Parameter**                            | **Icon** |
|:-----------------------------------------|:---------|
| MessageBoxIcon.Asterisk  <br> MessageBoxIcon.Information            <table><thead><th> <img src='http://wiki.code-ladder.googlecode.com/git/images/iconInfo.png' /> </th></thead><tbody>
<tr><td> MessageBoxIcon.Error  <br> MessageBoxIcon.Hand <br> MessageBoxIcon.Stop            </td><td> <img src='http://wiki.code-ladder.googlecode.com/git/images/iconError.png' /> </td></tr>
<tr><td> MessageBoxIcon.Exclamation  <br> MessageBoxIcon.Warning            </td><td> <img src='http://wiki.code-ladder.googlecode.com/git/images/iconWarn.png' /> </td></tr>
<tr><td> MessageBoxIcon.Question           </td><td> <img src='http://wiki.code-ladder.googlecode.com/git/images/iconQuestion.png' /> </td></tr></tbody></table>

<h2>Example</h2>
The following statement displays a message box and selects Button2 (the No button) as the default button:<br>
<br>
<pre><code>MessageBox.Show( "Do you really want to exit?",  _<br>
                 "Confirm Exit", _<br>
                  MessageBoxButtons.YesNo,  _<br>
                  MessageBoxIcon.Question, _<br>
                  MessageBoxDefaultButton.Button2 )<br>
<br>
</code></pre>
<img src='http://wiki.code-ladder.googlecode.com/git/images/exitBox.png' />


<h2>Return Values</h2>

The MessageBox.Show function returns a value corresponding to the button that was clicked.<br>
<br>
<table><thead><th> <b>Value</b>                               </th><th> <b>Meaning</b> </th></thead><tbody>
<tr><td> Windows.Forms.DialogResult.Abort      </td><td> The <i>Abort</i> button was clicked </td></tr>
<tr><td> Windows.Forms.DialogResult.Cancel     </td><td> The <i>Cancel</i> button was clicked </td></tr>
<tr><td> Windows.Forms.DialogResult.Ignore     </td><td> The <i>Ignore</i> button was clicked </td></tr>
<tr><td> Windows.Forms.DialogResult.No         </td><td> The <i>No</i> button was clicked </td></tr>
<tr><td> Windows.Forms.DialogResult.OK         </td><td> The <i>OK</i> button was clicked </td></tr>
<tr><td> Windows.Forms.DialogResult.Retry      </td><td> The <i>Retry</i> button was clicked </td></tr>
<tr><td> Windows.Forms.DialogResult.Yes        </td><td> The <i>Yes</i> button was clicked </td></tr></tbody></table>

As a programmer you can use the return value to take different actions based on the user selections.<br>
<br>
<pre><code>Dim retVal as Windows.Forms.DialogResult<br>
<br>
retVal = MessageBox.Show( "Do you really want to exit?",  _<br>
                          "Confirm Exit", _<br>
                           MessageBoxButtons.YesNo,  _<br>
                           MessageBoxIcon.Question, _<br>
                           MessageBoxDefaultButton.Button2 )<br>
<br>
If retVal = Windows.Forms.DialogResult.Yes Then<br>
    Me.Close()<br>
End If<br>
<br>
</code></pre>


<h2>More to Explore</h2>
<ul><li><a href='https://www.youtube.com/watch?v=Kcrt7cofpWY'>MessageBox video</a> from <a href='https://www.thenewboston.com/videos.php'>thenewboston</a>
</li><li><a href='https://www.youtube.com/watch?v=K37JMVKaVUw'>MessageBox return values video</a> from <a href='https://www.thenewboston.com/videos.php'>thenewboston</a>
</li><li><a href='https://msdn.microsoft.com/en-us/library/ctd56yay(v=vs.110).aspx'>MessageBox.Show</a> from MSDN