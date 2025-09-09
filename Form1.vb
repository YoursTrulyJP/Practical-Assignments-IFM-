'Form1.vb

Private intialallowance As Double
    Private Numwithdraw As Double
    Private Balance As Double
    Private Balance1 As Double
    Private balance2 As Double
    Private balance3 As Double
    Private counter As Double
    Private numbers(7) As Double
    Private numberadded As Double
    Private sum As Double
    Private Totalbalance As Double
    Private Average As Double

    Private Sub PLACETEXTIG(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdMynumbers.Row = r
        grdMynumbers.Col = c
        grdMynumbers.Text = t
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PLACETEXTIG(0, 0, "Number of transaction")
        PLACETEXTIG(0, 1, "Week 1")
        PLACETEXTIG(0, 2, "Week 2")
        PLACETEXTIG(0, 3, "Week 3")
        PLACETEXTIG(0, 4, "Week 4")



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        intialallowance = CDbl(txtintialallowanc.Text)
        numberadded = 7


        ReDim numbers(numberadded)
        sum = 0
        grdMynumbers.Rows = numberadded + 4
        'week 1
        For counter = 1 To 7
            numbers(counter) = CInt(InputBox("Enter amount of money you want to withdraw"))
            While Numwithdraw > Balance
                MsgBox("Your Balance is: R " + CStr(Balance) + " and you want to withdraw: R " + CStr(Numwithdraw))
                Numwithdraw = CDbl(InputBox("Re-Enter the amount you want to withdraw"))
            End While
            'grdMynumbers.Row = counter
            'grdMynumbers.Col = 0
            'grdMynumbers.Text = CStr(counter)

            'grdMynumbers.Col = 1
            'grdMynumbers.Text = CStr(numbers(counter))

            PLACETEXTIG(counter, 0, CStr(counter))
            PLACETEXTIG(0, 0, CStr(numbers(counter)))

            sum += numbers(counter)
        Next

        Balance = intialallowance - sum
        grdMynumbers.Row = 8

        grdMynumbers.Col = 0
        grdMynumbers.Text = CStr("Balance:")

        grdMynumbers.Col = 1
        grdMynumbers.Text = CStr(sum)


        Balance -= Numwithdraw

        If Balance <= 0 Then
            MsgBox("No more transactions allowed")
        Else
            If Balance <= 50 Then
                MsgBox("Your balance is lower than or equal to R50")
            End If
        End If
        grdMynumbers.Row = counter
        grdMynumbers.Col = 0
        grdMynumbers.Text = CStr(counter)

        grdMynumbers.Col = 1
        grdMynumbers.Text = CStr(numbers(counter))

        'Code commented out:
        'WEEK 2

        'intialallowance = CDbl(txtintialallowanc.Text)
        'numberadded = 7


        'ReDim numbers(numberadded)
        'sum = 0
        'grdMynumbers.Rows = numberadded + 2

        For counter = 1 To 7
            numbers(counter) = CInt(InputBox("Enter amount of money you want to withdraw"))
            While Numwithdraw > Balance
                MsgBox("Your Balance is :R " + CStr(Balance) + " and you want to withdraw: R " + CStr(Numwithdraw))
                Numwithdraw = CDbl(InputBox("Re-Enter the amount you want to withdraw"))
            End While

            grdMynumbers.Row = counter
            grdMynumbers.Col = 0
            grdMynumbers.Text = CStr(counter)

            grdMynumbers.Col = 2
            grdMynumbers.Text = CStr(numbers(counter))

            'PLACETEXTIG(counter, 0, CStr(counter))
            'PLACETEXTIG(0, 2, CStr(numbers(counter)))

            sum += numbers(counter)
        Next
        Balance = intialallowance - sum

        grdMynumbers.Row = 8
        grdMynumbers.Col = 0
        grdMynumbers.Text = CStr("Balance:")

        grdMynumbers.Col = 2
        grdMynumbers.Text = CStr(sum)

        'PLACETEXTIG(8, 0, CStr("Balance:"))
        'PLACETEXTIG(0, 2, CStr(sum))

        Balance -= Numwithdraw

        If Balance <= 0 Then
            MsgBox("No more transactions allowed")
        Else
            If Balance <= 50 Then
                MsgBox("Your balance is equal or lower than R50")
            End If
        End If

        'WEEK 3
        'intialallowance = CDbl(txtintialallowanc.Text)
        'numberadded = 7


        'ReDim numbers(numberadded)
        'sum = 0
        'grdMynumbers.Rows = numberadded + 4

        For counter = 1 To 7
            numbers(counter) = CInt(InputBox("Enter amount of money you want to withdraw"))
            While Numwithdraw > Balance
                MsgBox("Your Balance is :R " + CStr(Balance) + " and you want to withdraw: R " + CStr(Numwithdraw))
                Numwithdraw = CDbl(InputBox("Re-Enter the amount you want to withdraw"))
            End While

            grdMynumbers.Row = counter
            grdMynumbers.Col = 0
            grdMynumbers.Text = CStr(counter)

            grdMynumbers.Col = 3
            grdMynumbers.Text = CStr(numbers(counter))



            sum += numbers(counter)
        Next
        Balance = intialallowance - sum

        grdMynumbers.Row = 8
        grdMynumbers.Col = 0
        grdMynumbers.Text = CStr("Balance: ")

        grdMynumbers.Col = 3
        grdMynumbers.Text = CStr(sum)

        'PLACETEXTIG(8, 0, CStr("Balance:"))
        'PLACETEXTIG(0, 3, CStr(sum))

        Balance -= Numwithdraw

        If Balance <= 0 Then
            MsgBox("No more transactions allowed")
        Else
            If Balance <= 50 Then
                MsgBox("Your balance is lower than or equal to R50")
            End If
        End If

        'Code commented out 
        'WEEK 4
        'intialallowance = CDbl(txtintialallowanc.Text)
        'numberadded = 7

        'ReDim numbers(numberadded)
        'sum = 0
        'grdMynumbers.Rows = numberadded + 2

        For counter = 1 To 7
            numbers(counter) = CInt(InputBox("Enter amount of money you want to withdraw"))
            While Numwithdraw > Balance
                MsgBox("Your Balance is: R " + CStr(Balance) + " and you want to withdraw: R " + CStr(Numwithdraw))
                Numwithdraw = CDbl(InputBox("Re-Enter the amount you want to withdraw"))
            End While
            grdMynumbers.Row = counter
            grdMynumbers.Col = 0
            grdMynumbers.Text = CStr(counter)

            grdMynumbers.Col = 4
            grdMynumbers.Text = CStr(numbers(counter))

            'PLACETEXTIG(counter, 0, CStr(counter))
            'PLACETEXTIG(0, 4, CStr(numbers(counter)))

            sum += numbers(counter)
        Next
        Balance = intialallowance - sum

        grdMynumbers.Row = 8
        grdMynumbers.Col = 0
        grdMynumbers.Text = CStr("Balance: ")

        grdMynumbers.Col = 4
        grdMynumbers.Text = CStr(sum)

        PLACETEXTIG(8, 0, CStr("Balance: "))
        PLACETEXTIG(0, 4, CStr(sum))

        Balance -= Numwithdraw
        If Balance <= 0 Then
            MsgBox("No more transactions allowed")
        Else
            If Balance <= 50 Then
                MsgBox("Your balance is lower than or equal to R50")
            End If
        End If

        Totalbalance = Balance1 + balance2 + balance3 + Balance
        Average = Totalbalance / 4

    End Sub
End Class

