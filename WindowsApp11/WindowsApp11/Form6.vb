Public Class Form6
    Dim result As Integer
    Dim deposit As Integer
    Dim bankaccount As Integer = 1000
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Insert the amount of money you want to take from the bank.", "Bank")
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles Moneytaking.ValueChanged
        deposit = Moneytaking.Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnOkay.Click
        bankaccount = 1000 - deposit    'Take money from the bank
        lblaccountmoney.Text = "Your total money in your bank account is $" & bankaccount
        If Form2.turn = 1 Then
            Form2.player1money += deposit
            Form2.UpdatePlayer1Money()
            lbltotalmoney.Text = "Your total money is $" & Form2.player1money
        ElseIf Form2.turn = 2 Then
            Form2.player2money += deposit
            Form2.UpdatePlayer2Money()
            lbltotalmoney.Text = "Your total money is $" & Form2.player2money
        End If
        MessageBox.Show("You are leaving bank now.")
        Me.Hide()
        Form2.Show()
    End Sub
End Class