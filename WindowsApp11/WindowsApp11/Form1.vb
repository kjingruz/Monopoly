Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Choose your Character"
        MessageBox.Show("The boy is going to be Player1 and the girl is going to be Player2. Please decide which character you are going to be.", "Choose Your Character")
    End Sub

    Private Sub BtnOkay_Click(sender As Object, e As EventArgs) Handles BtnOkay.Click
        MessageBox.Show("Okay, the game is starting now!")
        Form2.Show()
        Me.Hide()
    End Sub
End Class
