# Definiton #

A ListBox control
displays a list of items and also allows the user to select one or more items from the list.

It may display a scroll bar when all the items cannot be shown.

To create a ListBox control, double-click the ListBox ison in the ToolBox window and position or resize the ListBox as needed.

# The Items Property #

The entries displayed to the user are stored in the _Items_ property of the ListBox control.

Some facts about the _Items_ property:
  * The _Items_ property holds a list of values from which the user may choose.
  * The _Items_ property may be set at design time or at run time
  * _Items_ is a CollectionObject and stores a collection of Strings.  Only Strings can be stored in the _Items_ property.


## Adding items ##
To store values in the Items property at design time:
  * Select the ListBox control in the _**Designer**_ window
  * In the _**Properties**_ window, click the Items (Collection) ellipsis button (...)
  * Type each value on a separate line in the _**String Collection Editor**_ dialog box

To store values in the _Items_ property with code at runtime, use the **Items.Add** function:`
The general format is:
```
ListBox.Items.Add (SomeStringItem)
```
where:
  * ListBox is the name of the ListBox control
  * Item is the value to be added to the Items property

The add function returns the new item position in the list, but you don't have to use it.


Examples:
```
lstStudents.Items.Add ("Sharon")

lstCities.Items.Add (txtCityName.Text)

Dim i As Integer
i = lstAnimals.Items.Add ("Aardvark")

```

## Other ListBox Properties and Methods ##
| **Name and arguments**  | **Type**      | Description |
|:------------------------|:--------------|:------------|
| Add (item As Object)  | Function    | Adds items to the collection, returning the new item index position |
| Clear ()              | Subroutine  | Removes all items from the collection. |
| Contains (value As Object)  | Function    | Checks the collection for _value_, returning _True_ is value is found at least once in the collection |
| Count               | Property      | Returns the number of items in the collection. |
| IndexOf (value As Object)  | Function    | Returns the index position of the occurrence of _value_ in the collection.  If _value is not found, then_-1_is returned._|
| Insert (index As Integer, <br> item As Object) <table><thead><th> Subroutine </th><th> Inserts an item in the collection at the provided index position. </th></thead><tbody>
<tr><td> Item (index As Integer)  </td><td> Property    </td><td> Returns the item at the specified index position. </td></tr>
<tr><td> Remove (value As Object)  </td><td> Subroutine    </td><td> Deletes the item at the occurrence of <i>value</i> in the collection. </td></tr>
<tr><td> RemoveAt (index As Integer)  </td><td> Subroutine    </td><td> Deletes the item at the specified index position. </td></tr>
<tr><td> SelectedIndex ()            </td><td> Function  </td><td> Returns the index position of the currently selected list item.  If nothing is selected, then <i>-1</i> is returned. </td></tr>
<tr><td> SelectedItem ()            </td><td> Function  </td><td> Returns the value of the currently selected item. </td></tr></tbody></table>




<h2>More to Explore</h2>
<ul><li><a href='https://msdn.microsoft.com/en-us/library/h5a2t8d9.aspx'>ListBox Control</a> from Microsoft Developer Network</li></ul>


