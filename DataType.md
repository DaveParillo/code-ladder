# Types #

The _**type**_ or _**DataType**_ defines the total size of storage in the computer memory,
used for holding information while the program is running.

Each DataType is able to store values up to the amount allowed by the DataType.
The Boolean type is the smallest and can store a single bit of information,
represented as either _**True**_ or _**False**_.


| **Type**       | **Definiton and Range**               |
|:---------------|:--------------------------------------|
| Boolean      | True or False                       |
| Byte         | Integer value from 0 - 255          |
| Char         | A single unicode character, for example 'X' |
| Date         | A date or time value, or both  |
| Decimal      | A high precision floating point number. 29 significant figures in the range +/- 7.9 x 10^28 |
| Double       | A floating point number with 15 significant figures in the range +/- 1.0 x 10^308 |
| Integer      | A whole number in the range +/- 2^31      |
| Long         | A whole number in the range +/- 2^63      |
| Object       | Everything in Visual Basic inherits from this type, so ultimately everything is an Object |
| Short        | A whole number in the range +/- 2^15      |
| Single       | A flaoting point number with 7 significant figures in the range +/- 1. x 10^38      |
| String       | An array of characters.  It can be very long.      |

## Literals ##

A _Literal_ is the term used to describe assigning an actual value to a variable,
as opposed to retrieving the value from a function or property.

When assigning a literal to a variable, you must ensure the literal is the correct size for your data type,
otherwise the compiler with throw an error.  This is especially true if you have [OptionStrict](OptionStrict.md) set to _On_.

Table of Literals

| **Type**       | **Description**               | **Example** |
|:---------------|:------------------------------|:------------|
| Boolean      | True and False              | False |
| Byte         | Whole Number between 0 & 255|  12 |
| Char         | Single letter in quotes followed by a lowercase c | "X"c  |
| Date         | Date or Time values surrounded by # | #11/23/1620#  |
| Decimal      | Number followed by D | 19.98D  |
| Double       | Number followed by R | 3.14159R  |
| Integer      | Number followed by I | 123I  |
| Long         | Number followed by L | -543210L  |
| Short        | Number followed by S | -123.457S  |
| Single       | Number followed by F | 11.99F  |
| String       | Characters surrounded by double quotes  | "Hello, World!  It's 123 day!"  |

## More to Explore ##
  * [Data Types in Visual Basic](https://msdn.microsoft.com/en-us/library/ffsdktda(v=vs.90).aspx) from Microsoft Developer Network
  * [Converting from One Variable Type to Another](https://msdn.microsoft.com/en-us/library/8bzk8e8c(v=vs.90).aspx) from Microsoft Developer Network
  * [Primitive Data Types video](https://www.youtube.com/watch?v=IneVm5aY2nM) from [thenewboston](https://www.thenewboston.com/videos.php)


