
''' <summary>
''' Stores the expected results for a puzzle.
''' A single Results object corresponds to a single 'results' element in the game XML DOM.
''' </summary>
Public Class Results
    Private pValue As String
    Private pProperty As String
    Private pParameters As Object()
    Private _p1 As Integer

    Public Sub New()
        MyBase.New()
        pValue = String.Empty
        pProperty = String.Empty
        pParameters = Nothing
    End Sub

    Sub New(ByVal Length As Integer)
        MyBase.New()
        pValue = String.Empty
        pProperty = String.Empty
        ReDim pParameters(Length - 1)
    End Sub

    Public Property Value() As String
        Get
            Return pValue
        End Get
        Set(ByVal value As String)
            pValue = value
        End Set
    End Property

    Public Property ObjectProperty() As String
        Get
            Return pProperty
        End Get
        Set(ByVal value As String)
            pProperty = value
        End Set
    End Property

    ' This setter needs some work.
    ' It's a hack
    Public Property Parameters() As Object()
        Get
            Return pParameters
        End Get
        Set(ByVal value As Object())
            Dim i As Integer
            Dim o As Object
            Dim temp(value.Length - 1) As Object

            For i = 0 To value.GetLength(0) - 1
                o = Nothing
                If IsNumeric(value(i)) Then
                    If Boolean.TryParse(value(i), o) Then
                        temp(i) = o
                    ElseIf Integer.TryParse(value(i), o) Then
                        temp(i) = o
                    ElseIf Double.TryParse(value(i), o) Then
                        temp(i) = o
                    ElseIf Date.TryParse(value(i), o) Then
                        temp(i) = o
                    Else
                        MessageBox.Show("Could not parse " & value(i).ToString)
                    End If

                Else
                    Try
                        temp(i) = value(i)
                    Catch ex As Exception
                        MessageBox.Show("Could not parse " & value(i).ToString _
                                        & vbNewLine & vbNewLine _
                                        & ex.Message)
                    End Try
                End If
            Next
            pParameters = temp
        End Set
    End Property

End Class
