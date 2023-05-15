
Code:



Public Class Form1
    'Valid variable for validation the process.
    Dim Valid As Boolean
    'Price variable for price of Items.
    Dim Price As Double
    'strFinalOrder for final recipt.
    Dim strFinalOrder As String
 
 
 
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
 
        Dim strType As String 'for selecting pizza type.
        Dim strSize, strOption As String 'for selecting pizza size and more option.
        strType = cbType.Text
        Dim intQuantity As Integer = Val(txtQuantity.Text)
 
        'show size in label.
        If rbSmall.Checked Then
            strSize = rbSmall.Text
        ElseIf rbMed.Checked Then
            strSize = rbMed.Text
        ElseIf rbLarge.Checked Then
            strSize = rbLarge.Text
        End If
        'show Option in Label.
        If chbExCheese.Checked Then
            strOption = chbExCheese.Text
        End If
        If chbExHam.Checked Then
            strOption = chbExHam.Text
        End If
        If chbExCheese.Checked And chbExHam.Checked Then
            strOption = chbExCheese.Text + chbExHam.Text
 
        End If
 
 
 
        If ValidateForm() Then
            If Calculation(strType) <> 0 Then
 
                lblResult.Text += CStr(Price * intQuantity)
                FillBillString(intQuantity)
                lblShow.Text = FillBillString(intQuantity).ToString
                MessageBox.Show(strFinalOrder)
            End If
        End If
    End Sub
 
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'For reset orders.
        lblShow.Text = String.Empty
        lblResult.Text = String.Empty
        chbExCheese.Checked = False
        chbExHam.Checked = False
        txtQuantity.Text = String.Empty
    End Sub
    Private Function ValidateForm() As Boolean
        Valid = True
        'validation of size selection.
        If rbSmall.Checked Or rbMed.Checked Or rbLarge.Checked Then
            Valid = True
        Else
            MessageBox.Show("Please select the pizza size!")
            Valid = False
            Return Valid
        End If
        'validation of Quantity selection.
        If txtQuantity.Text = String.Empty Then
            MessageBox.Show("please Enter Quantity!")
            Valid = False
            Return Valid
        End If
 
        If (txtQuantity.Text <= 10) Then
            Valid = True
        Else
            MessageBox.Show("The quantity is more than 10")
            Valid = False
            Return Valid
        End If
        Return Valid
    End Function

    Private Function Calculation(strType As String) As Double
 
        'Calculate the price order.
 
        Select Case strType
            Case "Peperoni"
                Price = 9.5
                If chbExCheese.Checked Then
                    Price += 1
                End If
                If chbExHam.Checked Then
                    Price += 1.5
                End If
                If rbSmall.Checked Then
                    Price += 0
                ElseIf rbMed.Checked Then
                    Price += 2
                ElseIf rbLarge.Checked Then
                    Price += 5
                End If
            Case "Mash and Ham"
                Price = 9
                If chbExCheese.Checked Then
                    Price += 1
                End If
                If chbExHam.Checked Then
                    Price += 1.5
                End If
                If rbSmall.Checked Then
                    Price += 0
                ElseIf rbMed.Checked Then
                    Price += 2
                ElseIf rbLarge.Checked Then
                    Price += 5
                End If
            Case "Vegetarian"
                Price = 8
                If chbExCheese.Checked Then
                    Price += 1
                End If
                If chbExHam.Checked Then
                    Price += 1.5
                End If
                If rbSmall.Checked Then
                    Price += 0
                ElseIf rbMed.Checked Then
                    Price += 2
                ElseIf rbLarge.Checked Then
                    Price += 5
                End If
            Case "Spacial"
                Price = 11
                If chbExCheese.Checked Then
                    Price += 1
                End If
                If chbExHam.Checked Then
                    Price += 1.5
                End If
                If rbSmall.Checked Then
                    Price += 0
                ElseIf rbMed.Checked Then
                    Price += 2
                ElseIf rbLarge.Checked Then
                    Price += 5
                End If
 
        End Select
 
        Return Price
    End Function
 
 
    Private Function FillBillString(intQuant As Integer) As String
 
        'Header of the recipt.
        strFinalOrder = " Pizza Order Recipt" & Environment.NewLine
        strFinalOrder += $"{TimeOfDay.ToLongTimeString} {Today.ToLongDateString}" & Environment.NewLine
        strFinalOrder += "-------------------------------------------------------------------" & Environment.NewLine
 
        'Order List
        strFinalOrder += cbType.Text & Environment.NewLine
        strFinalOrder += "Quantity: " & txtQuantity.Text & Environment.NewLine
        If chbExCheese.Checked Or chbExHam.Checked Then
            strFinalOrder += "Option: " & Environment.NewLine
            If chbExCheese.Checked Then
                strFinalOrder += "Extra Cheese" & Environment.NewLine
            End If
            If chbExHam.Checked Then
                strFinalOrder += "Extra Ham" & Environment.NewLine
            End If
        End If
        strFinalOrder += "Size:" & Environment.NewLine
        If rbSmall.Checked Then
            strFinalOrder += "Small" & Environment.NewLine
        ElseIf rbMed.Checked Then
            strFinalOrder += "Medium" & Environment.NewLine
        ElseIf rbLarge.Checked Then
            strFinalOrder += "Large" & Environment.NewLine
        End If
        'Footer of recipt
        strFinalOrder += "Price:" + CStr(Price * intQuant) & Environment.NewLine
        strFinalOrder += "Thank you for shopping"
        Return strFinalOrder
    End Function
 
 
End Class

