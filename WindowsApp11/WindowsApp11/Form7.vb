Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Guards don't like visitors, so they arrested you. Now there are nine chests in front of you that one of them has the key to escape and you may only open one. Try your luck.", "Chest")
        Randomize()
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True
        PictureBox7.Enabled = True
        PictureBox8.Enabled = True
        PictureBox9.Enabled = True
        PictureBox10.Enabled = True
        PictureBox2.Image = My.Resources.chest1
        PictureBox3.Image = My.Resources.chest1
        PictureBox4.Image = My.Resources.chest1
        PictureBox5.Image = My.Resources.chest1
        PictureBox6.Image = My.Resources.chest1
        PictureBox7.Image = My.Resources.chest1
        PictureBox8.Image = My.Resources.chest1
        PictureBox9.Image = My.Resources.chest1
        PictureBox10.Image = My.Resources.chest1
    End Sub
    Private Sub picturebox_click(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click, PictureBox10.Click
        Dim rnd As Random = New Random  'Random draw to choose the chest
        Dim answer As Integer = rnd.Next(1, 10)
        Dim choosechest As PictureBox = sender
        If Val(choosechest.Tag) = answer Then
            choosechest.Image = My.Resources.key
            MessageBox.Show("Congradulations! You find the key, so you escaped before the guards noticed you.")
        Else
            choosechest.Image = My.Resources.emptychest
            MessageBox.Show("You did not find the key, therefore, you are fined $200.")
            If Form2.turn = 1 Then
                Form2.player1money -= 200
                Form2.UpdatePlayer1Money()
            ElseIf Form2.turn = 2 Then
                Form2.player2money -= 200
                Form2.UpdatePlayer2Money()
            End If
        End If
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        PictureBox6.Enabled = False
        PictureBox7.Enabled = False
        PictureBox8.Enabled = False
        PictureBox9.Enabled = False
        PictureBox10.Enabled = False
        Me.Hide()
        Form2.Show()
    End Sub
End Class