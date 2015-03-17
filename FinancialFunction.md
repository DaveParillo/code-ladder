# Pmt Function #
Returns a Double specifying the payment for an annuity based on
periodic, fixed payments and a fixed interest rate.
```
Public Function Pmt(Rate As Double, _
                    NPer As Double, _
                    PV As Double, _
                    Optional FV As Double = 0.0, _
                    Optional Due As Microsoft.VisualBasic.DueDate = EndOfPeriod) As Double
```

The PMT Function is a member of the Microsoft.VisualBasic.Financial namespace.

## Parameters ##
  * **Rate:** Required. The interest rate per period.
> > For example, if you get a car loan at an annual percentage rate (APR) of
    1. percent and make monthly payments, the rate per period is 0.1/12, or 0.0083.
  * **NPer:** Required. The total number of payment periods in the annuity.
> > For example, if you make monthly payments on a four-year car loan, then
> > your loan has a total of 4 × 12 (or 48) payment periods.
  * **PV:** Required. The present value (or lump sum) that a series of payments
> > to be paid in the future is worth now.
> > For example, when you borrow money to buy a car,
> > the loan amount is the present value to the lender of the monthly car
> > payments you will make.
  * **FV:** Optional. Future value or cash balance you want after you have made the final payment.
> > For example, the future value of a loan is $0 because that is its value
> > after the final payment.
> > However, if you want to save $50,000 during 18 years for your child's education,
> > then $50,000 is the future value. If omitted, 0 is assumed.
  * **Due:** Optional. Object of type Microsoft.VisualBasic.DueDate that specifies when payments are due.
> > This argument must be either DueDate.EndOfPeriod if payments are due at the end of the payment period,
> > or DueDate.BegOfPeriod if payments are due at the beginning of the period.
> > If omitted, DueDate.EndOfPeriod is assumed.


## Exceptions ##
If the **NPer** argument = 0, then a System.ArgumentException is thrown.
See TryCatch for how to handle exceptions.





## Example ##
```
Dim dblPayment As Double
Dim dblAnnualInterest As Double = 0.065    ' 6.5 %'

dblPayment = Pmt (dblAnnualInterest / 12R, 60, 15000)      ' dblPayment = -293.49 '
dblPayment = Pmt (dblAnnualInterest / 12R, 60, -15000)     ' dblPayment =  293.49 '

```


# IPMT Function #
IPMT is very similar to the Pmt function.

IPMT returns a Double specifying the interest payment for an annuity in a specific period,
based on periodic, fixed payments and a fixed interest rate.

```
Public Function Pmt(Rate As Double, _
                    Per As Double, _
                    NPer As Double, _
                    PV As Double, _
                    Optional FV As Double = 0.0, _
                    Optional Due As Microsoft.VisualBasic.DueDate = EndOfPeriod) As Double
```

The IPMT Function is a member of the Microsoft.VisualBasic.Financial namespace.

## Parameters ##
  * **Rate:** Required. The interest rate per period.
> > For example, if you get a car loan at an annual percentage rate (APR) of
    1. percent and make monthly payments, the rate per period is 0.1/12, or 0.0083.
  * **Period:** Required. The specif payment from 1 to NPer you want to calculate interest for.
  * **NPer:** Required. The total number of payment periods in the annuity.
> > For example, if you make monthly payments on a four-year car loan, then
> > your loan has a total of 4 × 12 (or 48) payment periods.
  * **PV:** Required. The present value (or lump sum) that a series of payments
> > to be paid in the future is worth now.
> > For example, when you borrow money to buy a car,
> > the loan amount is the present value to the lender of the monthly car
> > payments you will make.
  * **FV:** Optional. Future value or cash balance you want after you have made the final payment.
> > For example, the future value of a loan is $0 because that is its value
> > after the final payment.
> > However, if you want to save $50,000 during 18 years for your child's education,
> > then $50,000 is the future value. If omitted, 0 is assumed.
  * **Due:** Optional. Object of type Microsoft.VisualBasic.DueDate that specifies when payments are due.
> > This argument must be either DueDate.EndOfPeriod if payments are due at the end of the payment period,
> > or DueDate.BegOfPeriod if payments are due at the beginning of the period.
> > If omitted, DueDate.EndOfPeriod is assumed.


## Exceptions ##
If the **Per** argument <= 0 or **Per** > **NPer**, then a System.ArgumentException is thrown.
See TryCatch for how to handle exceptions.

## PPMT Function ##
The Principal Payment function takes the same arguments as the IPMT Function.

The PPMT function returns the principal payment for an annuity in a specific period,
based on periodic fixed payments at a fixed interest rate.



## Examples ##
```
Dim dblPayment As Double
Dim dblInterest As Double
Dim dblPrincipal As Double
Dim dblRate As Double = 0.065    ' 6.5 %'

dblPayment   = Pmt (dblRate / 12R, 60, -15000)       ' Monthly payment '
dblInterest  = IPmt (dblRate / 12R, 1, 60, -15000)   ' First month interest '
dblPrincipal = PPmt (dblRate / 12R, 1, 60, -15000)   ' First month Principal '

If dblPayment = (dblInterest + dblPrincipal) Then
    MessageBox.Show ("All is well.")
Else
    MessageBox.Show ("This should never happen! Our payment is not equal to principal + interest.") 
EndIf

```



## More to Explore ##
  * [Financial Summary](https://msdn.microsoft.com/en-us/library/daksysx3(v=vs.110).aspx) from Microsoft Developer Network (MSDN)

  * [PMT Method](https://msdn.microsoft.com/en-us/library/microsoft.visualbasic.financial.pmt(v=vs.110).aspx) from MSDN



