'frmMonAL.vb

Public Class frmMonAL

    'Variable declarations

    Private Allocatedallowance As Double
    Private AverageAmountSpent As Double
    Private Trans As Integer
    Private NTrans(7)As Integer
    Private Counter As Double
    Private Sum As Double
    Private BalW1 As Double
    Private BalW2 As Double
    Private BalW3 As Double
    Private BalW4 As Double
    Private balrem1 As Double
    Private balrem2 As Double
    Private balrem3 As Double
    Private balrem4 As Double




    Private Sub btnSetALAL_Click(sender As Object, e As EventArgs) Handles btnSetALAL.Click
        Allocatedallowance = CDbl(txtAlAl.Text)
        BalW1 = Allocatedallowance
    End Sub

    Private Sub btnW1_Click(sender As Object, e As EventArgs) Handles btnW1.Click

        Trans = 7
        ReDim NTrans(Trans)
        Sum = 0
        grdMonAL.Rows = Trans + 4

        For Counterss = 1 To 7

            NTrans(Counterss) = CInt(InputBox("enter the transaction amount for " & CStr(Counterss)))
            grdMonAL.Row = CInt(CDbl(Counterss))
            grdMonAL.Col = 0
            grdMonAL.Text = CStr(Counterss)
            grdMonAL.Row = CInt(CDbl(Counterss))
            grdMonAL.Col = 1
            grdMonAL.Text = CStr(CDbl(NTrans(Counterss)))
            Sum += NTrans(Counterss)

        Next

        If CStr(Sum) >= Allocatedallowance Then
            MsgBox("No more transactions allowed")
        Else
            If CStr(Sum) >= (Allocatedallowance - 50) Then
                MsgBox("Your balance is equal or lower than R50")
            End If
        End If

        balrem1 = Allocatedallowance - Sum
        grdMonAL.Row = 8
        grdMonAL.Col = 0
        grdMonAL.Text = "total amount spent:"
        grdMonAL.Row = 8
        grdMonAL.Col = 1
        grdMonAL.Text = CStr(Sum)

        grdMonAL.Row = 9
        grdMonAL.Col = 0
        grdMonAL.Text = "average amount spent:"
        grdMonAL.Row = 9
        grdMonAL.Col = 1
        grdMonAL.Text = CStr(Sum) / 7

        grdMonAL.Row = 10
        grdMonAL.Col = 0
        grdMonAL.Text = "balance remaining:"
        grdMonAL.Row = 10
        grdMonAL.Col = 1
        grdMonAL.Text = Allocatedallowance - CStr(Sum)

    End Sub

    Private Sub frmMonAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'Grid populatoin

        grdMonAL.Row = 0
        grdMonAL.Col = 0
        grdMonAL.Text = "Number of transactions"


        grdMonAL.Row = 8
        grdMonAL.Col = 0
        grdMonAL.Text = "Total Amount Spent"
        grdMonAL.Row = 9
        grdMonAL.Col = 0
        grdMonAL.Text = "Average Amount Spent"
        grdMonAL.Row = 10
        grdMonAL.Col = 0
        grdMonAL.Text = "Balance remaining"

        grdMonAL.Row = 0
        grdMonAL.Col = 1
        grdMonAL.Text = "1st Week"
        grdMonAL.Row = 0
        grdMonAL.Col = 2
        grdMonAL.Text = "2nd Week"
        grdMonAL.Row = 0
        grdMonAL.Col = 3
        grdMonAL.Text = "3rd Week"
        grdMonAL.Row = 0
        grdMonAL.Col = 4
        grdMonAL.Text = "4th Week"
        grdMonAL.Row = 0
        grdMonAL.Col = 5
        grdMonAL.Text = "Monthly total"

    End Sub

    Private Sub btnW2_Click(sender As Object, e As EventArgs) Handles btnW2.Click
        BalW2 = balrem1

        grdMonAL.Rows = Trans + 4

        For Counterss = 1 To 7
            NTrans(Counterss) = CInt(InputBox("Enter the transaction amount for " & CStr(Counterss)))
            grdMonAL.Row = CInt(CDbl(Counterss))
            grdMonAL.Col = 0
            grdMonAL.Text = CStr(Counterss)
            grdMonAL.Row = CInt(CDbl(Counterss))
            grdMonAL.Col = 2
            grdMonAL.Text = CStr(CDbl(NTrans(Counterss)))


            Sum += NTrans(Counterss)
        Next
        If CStr(Sum) >= Allocatedallowance Then
            MsgBox("No more transactions allowed")
        Else
            If CStr(Sum) >= (Allocatedallowance - 50) Then
                MsgBox("Your balance is lower than or equal to R50")
            End If
        End If
        balrem2 = balrem1 - Sum
        grdMonAL.Row = 8
        grdMonAL.Col = 2
        grdMonAL.Text = CStr(Sum)

        BalW2 = Allocatedallowance - Sum
        grdMonAL.Row = 9
        grdMonAL.Col = 2
        grdMonAL.Text = CStr(Sum) / 7

        BalW2 = Allocatedallowance - Sum
        grdMonAL.Row = 10
        grdMonAL.Col = 2
        grdMonAL.Text = Allocatedallowance - CStr(Sum)

    End Sub

    Private Sub btnW3_Click(sender As Object, e As EventArgs) Handles btnW3.Click


        BalW3 = balrem2

        grdMonAL.Rows = Trans + 4

        For Counterss = 1 To 7
            NTrans(Counterss) = CInt(InputBox("enter the transaction amount for " & CStr(Counterss)))
            grdMonAL.Row = CInt(CDbl(Counterss))
            grdMonAL.Col = 0
            grdMonAL.Text = CStr(Counterss)
            grdMonAL.Row = CInt(CDbl(Counterss))
            grdMonAL.Col = 3
            grdMonAL.Text = CStr(CDbl(NTrans(Counterss)))


            Sum += NTrans(Counterss)
        Next
        If CStr(Sum) >= Allocatedallowance Then
            MsgBox("No more transactions allowed")
        Else
            If CStr(Sum) >= (Allocatedallowance - 50) Then
                MsgBox("Your balance is lower than or equal to R50")
            End If
        End If
        balrem3 = balrem2 - Sum
        grdMonAL.Row = 8
        grdMonAL.Col = 3
        grdMonAL.Text = CStr(Sum)

        BalW3 = Allocatedallowance - Sum
        grdMonAL.Row = 9
        grdMonAL.Col = 3
        grdMonAL.Text = CStr(Sum) / 7

        BalW2 = Allocatedallowance - Sum
        grdMonAL.Row = 10
        grdMonAL.Col = 3
        grdMonAL.Text = Allocatedallowance - CStr(Sum)


    End Sub

    Private Sub btnW4_Click(sender As Object, e As EventArgs) Handles btnW4.Click

        BalW4 = balrem3

        grdMonAL.Rows = Trans + 4

        For Counterss = 1 To 7
            NTrans(Counterss) = CInt(InputBox("Enter the transaction amount for " & CStr(Counterss)))
            grdMonAL.Row = CInt(CDbl(Counterss))
            grdMonAL.Col = 0
            grdMonAL.Text = CStr(Counterss)
            grdMonAL.Row = CInt(CDbl(Counterss))
            grdMonAL.Col = 4
            grdMonAL.Text = CStr(CDbl(NTrans(Counterss)))


            Sum += NTrans(Counterss)
        Next
        If CStr(Sum) >= Allocatedallowance Then
            MsgBox("No more transactions allowed")
        Else
            If CStr(Sum) >= (Allocatedallowance - 50) Then
                MsgBox("Your balance is lower than or equal to R50")
            End If
        End If
        balrem3 = balrem2 - Sum
        grdMonAL.Row = 8
        grdMonAL.Col = 4
        grdMonAL.Text = CStr(Sum)

        BalW3 = Allocatedallowance - Sum
        grdMonAL.Row = 9
        grdMonAL.Col = 4
        grdMonAL.Text = CStr(Sum) / 7

        BalW2 = Allocatedallowance - Sum
        grdMonAL.Row = 10
        grdMonAL.Col = 4

        grdMonAL.Text = Allocatedallowance - CStr(Sum)
    End Sub

End Class
