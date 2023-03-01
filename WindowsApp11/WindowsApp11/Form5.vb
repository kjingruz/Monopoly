Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intro As Integer = MessageBox.Show("The object of the game is to become the wealthiest player through buying and selling of property. Starting with the Banker, each player in turn throws the dice. The player with the highest total starts the play. Place your token on the corner marked GO, then throw the dice and move your token
(in the direction of the arrow) the number of spaces indicated by the dice.
After you have completed your play, the turn passes to the left. The tokens remain on the spaces occupied and proceed from that point on the player's next turn. Two or more tokens may rest on the same space at the same time.
Depending on the space your token reaches, you may be entitled to buy real estate or other properties, or be obliged to pay rent, pay taxes, draw a Chance or Community Chest card, Go To Jail, or etc...
If you throw doubles, you move your token as usual, the sum of the two dice, and are subject to any privileges or penalties pertaining to the space on which you land. Retaining the dice, throw again and move your token as before. If you throw doubles three times in succession, move your token immediately to the space marked In Jail.", "Instructions", MessageBoxButtons.OKCancel)
        If intro = DialogResult.Yes Then    'Introduction of the game
            Me.Hide()
            Form1.Show()
        ElseIf intro = DialogResult.Cancel Then
            Me.Show()
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Monopoly"
    End Sub
End Class