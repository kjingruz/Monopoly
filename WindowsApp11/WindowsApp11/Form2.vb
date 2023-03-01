Public Class Form2
    Public player1money As Integer = 1000 'Player1's money
    Public player2money As Integer = 1000 'Player2's money
    Dim imagelocation(14) As Point  'My own Array to keep track of the location of the positions, so that the character icon can move to the specific position.
    Dim rnd As New Random   'Random Code
    Dim chance As Integer = 0   'the variable when player is on chance
    Dim communitychest As Integer = 0   'the variable when player is on community chest 
    Dim player1movement As Integer = 0  'The variable that keeps track of the amount of dice for Player1
    Dim player2movement As Integer = 0  'The variable that keeps track of the amount of dice for Player2
    Dim player1jail As Boolean = False 'The boolean to test if Player1 has been arrested
    Dim player2jail As Boolean = False 'The boolean to test if Player2 has been arrested
    Public turn As Integer  'The variable that tells me which Player's turn is it
    Dim player1position As Integer = 1  'The variable that keeps track of where Player1 is 
    Dim player2position As Integer = 1  'The variable that keeps track of where Player2 is 
    Dim torontoplayer2 As Boolean = False   'The variable to tell whether toronto is bought by Player2
    Dim torontoplayer1 As Boolean = False   'The variable to tell whether toronto is bought by Player1
    Dim shanghaiplayer1 As Boolean = False  'The variable to tell whether shanghai is bought by Player1
    Dim shanghaiplayer2 As Boolean = False  'The variable to tell whether shanghai is bought by Player2
    Dim beijingplayer1 As Boolean = False   'The variable to tell whether beijing is bought by Player1
    Dim beijingplayer2 As Boolean = False   'The variable to tell whether beijing is bought by Player2
    Dim montrealplayer2 As Boolean = False  'The variable to tell whether montreal is bought by Player2
    Dim montrealplayer1 As Boolean = False  'The variable to tell whether montreal is bought by Player1
    Dim player1injail As Boolean = False    'The variable to tell whether Player1 is in jail or not
    Dim player2injail As Boolean = False    ''The variable to tell whether Player2 is in jail or not
    Sub Afterrolldiceplayer1() 'The codes that shows what is happening when the player1 is on that certain point
        If Player1.Location = imagelocation(1) Then 'When Player1 is on the Go point
            MessageBox.Show("Salary Day, you gain $500")
            player1money += 500
            player1position = 1
        End If
        If Player1.Location = imagelocation(2) Then 'When Player1 is on the Chance 
            chance = rnd.Next(1, 5) 'There are 4 possible solutions end up happening by random draw
            If chance = 1 Then
                MessageBox.Show("You found a wallet on the street! You gain $100!", "Chance")
                player1money += 150
                player1position = 2
            ElseIf chance = 2 Then
                MessageBox.Show("You fell on the stairs and get injured. Hopsital charge you $100", "Chance")
                player1money -= 100
                player1position = 2
            ElseIf chance = 3 Then
                MessageBox.Show("School awarded you scholarship for keep on getting a 60 average. You gain $200", "Chance")
                player1money += 200
                player1position = 2
            Else
                MessageBox.Show("You broke your neighbor's window. You are asked to buy a new one. You lose $200", "Chance")
                player1money -= 100
                player1position = 2
            End If
        End If
        If Player1.Location = imagelocation(3) Then 'When Player1 is on Toronto
            If torontoplayer1 = True Or torontoplayer2 = True Then
                If torontoplayer2 = True Then
                    If Player1.Location = imagelocation(3) Then 'If Player2 has already bought Toronto
                        BtnBuyToronto.Enabled = False
                        MessageBox.Show("you just stepped on player2's toronto, you need to pay $100 rent.")
                        player1money -= 100
                        player2money += 100
                        player1position = 3
                    End If
                End If
                If torontoplayer1 = True Then   'If Player1 already bought Toronto
                    If Player1.Location = imagelocation(3) Then
                        BtnBuyToronto.Enabled = False
                        player1position = 3
                        MessageBox.Show("Welcome back")
                        BtnSellToronto.Enabled = True
                    End If
                End If
            Else    'If no one bought Toronto
                MessageBox.Show("You are in Toronto. The price for this land is $300 and you gain $100 if someone else is on it.", "Government of Toronto")
                BtnBuyToronto.Enabled = True
            End If
        End If
        If Player1.Location = imagelocation(4) Then 'When Player1 is on Montreal
            If montrealplayer1 = True Or montrealplayer2 = True Then
                If montrealplayer2 = True Then
                    If Player1.Location = imagelocation(4) Then 'If Player2 has already bought Montreal
                        BtnBuyMontreal.Enabled = False
                        MessageBox.Show("you just stepped on player2's Montreal, you need to pay $75 rent.")
                        player1money -= 75
                        player2money += 75
                        player1position = 4
                    End If
                End If
                If montrealplayer1 = True Then  'If Player1 has already bought Montreal
                    If Player1.Location = imagelocation(4) Then
                        BtnBuyMontreal.Enabled = False
                        player1position = 4
                        MessageBox.Show("Welcome back")
                        BtnSellMontreal.Enabled = True
                    End If
                End If
            Else    'If no one bought Montreal
                MessageBox.Show("You are in Montreal. The price for this land is $250 and you gain $75 if someone else is on it.", "Government of Montreal")
                BtnBuyMontreal.Enabled = True
            End If
        End If
        If Player1.Location = imagelocation(5) Then 'When Player1 is on the Go to Jail
            MessageBox.Show("You are caught stealing things, you are arrested. Cannot move For a round.", "Police Man")
            player1jail = True 'The variable changed, so that it tells Player1 is arrested
            Player1.Location = imagelocation(12) 'Going to jail
            player1position = 12
        End If
        If Player1.Location = imagelocation(6) Then 'When Player1 is on the Electricity Company
            MessageBox.Show("Your electricity does not work anymore and you asked an elctric company To fix it for you. They charge you $150", "Electricity Company Notice")
            player1money -= 150
            player1position = 6
        End If
        If Player1.Location = imagelocation(7) Then 'When Player1 is on the Community Chest
            communitychest = rnd.Next(1, 5) '4 different kinds of things happening by random draw
            If communitychest = 1 Then
                Dim result As Integer = MessageBox.Show("You were doing community service And the coordinator liked you very much. She introduced you To Shanghai where she was born, Would you like to go?.", "Community Chest", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then   'You have the choice of going to Shanghai or not
                    MessageBox.Show("You are travelling to Shanghai now, the plane ticket costed you $100", "Airport")
                    player1money -= 100
                    Player1.Location = imagelocation(9)
                    player1position = 9
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("You have decided not travel, so stayed at where you are.", "Community Chest")
                    player1money += 0
                    player1position = 7
                End If
            ElseIf communitychest = 2 Then
                MessageBox.Show("You found a wallet and gave it To Policeman, but he thinks you stole it. You are arrested.", "Community Chest")
                Player1.Location = imagelocation(12)
                player1jail = True
            ElseIf communitychest = 3 Then
                MessageBox.Show("You went To see a Raptors Game, they lost and the ticket Is $100", "Community Chest")
                player1money -= 100
                player1position = 7
            ElseIf communitychest = 4 Then
                MessageBox.Show("You found an empty amount cheque with signature On it, what are you going to do? Press Return to give it to the bank Or Press use to use the cheque", "Community Chest")
                Form4.Show()
                player1position = 7
            End If
        End If
        If Player1.Location = imagelocation(8) Then 'When Player1 is on Beijing
            If beijingplayer1 = True Or beijingplayer2 = True Then
                If beijingplayer2 = True Then   'When Player2 has already bought Beijing
                    If Player1.Location = imagelocation(8) Then
                        BtnBuyBeijing.Enabled = False
                        MessageBox.Show("you just stepped on player1's Beijing, you need to pay $100 rent.")
                        player1money -= 100
                        player2money += 100
                    End If
                End If
                If beijingplayer1 = True Then   'When Player1 has already bought Beijing
                    If Player1.Location = imagelocation(8) Then
                        BtnBuyBeijing.Enabled = False
                        MessageBox.Show("Welcome back")
                        BtnSellBeijing.Enabled = True
                    End If
                End If
            Else    'When no one has bought Beijing
                MessageBox.Show("You are in Beijing. The price for this land is $300 and you gain $100 if someone else is on it.", "Government of Beijing")
                BtnBuyBeijing.Enabled = True
            End If
        End If
        If Player1.Location = imagelocation(9) Then 'When Player1 is in Shanghai
            If shanghaiplayer1 = True Or shanghaiplayer2 = True Then
                If shanghaiplayer2 = True Then  'When Player2 has bought Shanghai
                    If Player1.Location = imagelocation(9) Then
                        BtnBuyShanghai.Enabled = False
                        player1position = 9
                        MessageBox.Show("you just stepped on player2's Shanghai, you need to pay $100 rent.")
                        player2money += 100
                        player1money -= 100
                    End If
                End If
                If shanghaiplayer1 = True Then  'When Player1 has bought Shanghai
                    If Player1.Location = imagelocation(9) Then
                        BtnBuyShanghai.Enabled = False
                        player1position = 9
                        MessageBox.Show("Welcome back")
                        BtnSellShanghai.Enabled = True
                    End If
                End If
            Else    'When no one has bought Shanghai
                MessageBox.Show("You are in Shanghai. The price for this land is $300 and you gain $100 if someone else is on it.", "Government of Shanghai")
                BtnBuyShanghai.Enabled = True
            End If
        End If
        If Player1.Location = imagelocation(10) Then    'When Player1 is on Chance 
            chance = rnd.Next(1, 5) '4 different kinds of things happening by random draw
            If chance = 1 Then
                MessageBox.Show("You found a wallet on the street! You gain $100!", "Chance")
                player1money += 100
                player1position = 10
            ElseIf chance = 2 Then
                MessageBox.Show("You fell on the stairs And get injured. Hopsital charge you $100", "Chance")
                player1money -= 100
                player1position = 10
            ElseIf chance = 3 Then
                MessageBox.Show("School awarded you scholarship for being so nice to others. You gain $200", "Chance")
                player1money += 200
                player1position = 10
            Else
                MessageBox.Show("You broke your neighbor's window. You are asked to buy a new one. You lose $200", "Chance")
                player1money -= 200
                player1position = 10
            End If
        End If
        If Player1.Location = imagelocation(11) Then    'When Player1 has luxury tax
            MessageBox.Show("You bought too many luxurious things, therefore, the tax department are charging you $75 for showing off.", "Tax Department")
            player1money -= 75
            player1position = 11
        End If
        If Player1.Location = imagelocation(12) Then    'When Player1 is in jail
            If player1jail = True Then
                If player1injail = False Then
                    MessageBox.Show("Player1 is in jail, cannot play for one round.")
                    player1position = 12
                    player1injail = True
                End If
            ElseIf player1jail = False Then
                MessageBox.Show("Welcome to visit the jail.")
                Me.Hide()
                Form7.Show()
                player1position = 12
            End If
        End If
        If Player1.Location = imagelocation(13) Then    'When Player1 is on community chest
            communitychest = rnd.Next(1, 5)
            If communitychest = 1 Then
                Dim communitychesttravel As Integer = MessageBox.Show("You were doing community service And the coordinator liked you very much. She introduced you To Shanghai where she was born, Would you like to go?.", "Community Chest", MessageBoxButtons.YesNo)
                If communitychesttravel = DialogResult.Yes Then
                    MessageBox.Show("You are travelling to Shanghai now, the plane ticket costed you $100", "Airport")
                    player1money -= 100
                    Player1.Location = imagelocation(9) 'When Player1 decide to go to Shanghai
                    player1position = 9
                ElseIf communitychesttravel = DialogResult.No Then
                    MessageBox.Show("You have decided not travel, so stayed at where you are.", "Community Chest")
                    player1money += 0
                    player1position = 13
                End If
            ElseIf communitychest = 2 Then
                MessageBox.Show("You found a wallet And gave it To Policeman, but he thinks you stole it. You are arrested.", "Community Chest")
                Player1.Location = imagelocation(12)
                player1position = 12
                player1jail = True
            ElseIf communitychest = 3 Then
                MessageBox.Show("You went To see a Raptors Game, they lost and the ticket cost you $100", "Community Chest")
                player1money -= 100
                player1position = 13
            ElseIf communitychest = 4 Then
                MessageBox.Show("You found an empty amount cheque With signature On it, what are you going to do? Press Return to give it to the bank Or Press use to use the cheque", "Community Chest")
                Form4.Show()
                Me.Hide()
                player1position = 13
            End If
        End If
        If Player1.Location = imagelocation(14) Then    'When Player1 is on bank
            Dim result As Integer = MessageBox.Show("Do you want to visit the bank?", "Bank", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Me.Hide()
                Form6.Show()
                player1position = 14
            ElseIf result = DialogResult.No Then
                MessageBox.Show("OK!")
                player1position = 14
            End If

        End If
    End Sub
    Sub Afterrolldiceplayer2()  'These codes show what is happening to Player2 at certain point
        If Player2.Location = imagelocation(1) Then
            MessageBox.Show("Salary Day, you gain $500")
            player2money += 500
            player2position = 1
        End If
        If Player2.Location = imagelocation(2) Then
            chance = rnd.Next(1, 4)
            If chance = 1 Then
                MessageBox.Show("You found a wallet on the street! You gain $150!", "Chance")
                player2money += 150
                player2position = 2
            ElseIf chance = 2 Then
                MessageBox.Show("You fell on the stairs and get injured. Hopsital charge you $100", "Chance")
                player2money -= 100
                player2position = 2
            ElseIf chance = 3 Then
                MessageBox.Show("School awarded you scholarship for keep on getting a 60 average. You gain $200", "Chance")
                player2money += 200
                player2position = 2
            Else
                MessageBox.Show("You broke your neighbor's window. You are asked to buy a new one. You lose $200", "Chance")
                player2money -= 100
                player2position = 2
            End If
        End If
        If Player2.Location = imagelocation(3) Then
            If torontoplayer1 = True Or torontoplayer2 = True Then
                If torontoplayer1 = True Then
                    If Player2.Location = imagelocation(3) Then
                        BtnBuyToronto.Enabled = False
                        MessageBox.Show("you just stepped on player1's Toronto, you need to pay $100 rent.")
                        player2money -= 100
                        player1money += 100
                        player2position = 3
                    End If
                End If
                If torontoplayer2 = True Then
                    If Player2.Location = imagelocation(3) Then
                        BtnBuyToronto.Enabled = False
                        MessageBox.Show("Welcome back")
                        player2position = 3
                        BtnSellToronto.Enabled = True
                    End If
                End If
            Else
                MessageBox.Show("You are in Toronto. The price for this land is $300 and you gain $100 if someone else is on it.", "Government of Toronto")
                BtnBuyToronto.Enabled = True
            End If
        End If
        If Player2.Location = imagelocation(4) Then
            If montrealplayer1 = True Or montrealplayer2 = True Then
                If montrealplayer1 = True Then
                    If Player2.Location = imagelocation(4) Then
                        BtnBuyMontreal.Enabled = False
                        MessageBox.Show("You just stepped on Player1's Montreal, you need to pay $75 rent.")
                        player2money -= 75
                        player1money += 75
                        player2position = 4
                    End If
                End If
                If montrealplayer2 = True Then
                    If Player2.Location = imagelocation(4) Then
                        BtnBuyMontreal.Enabled = False
                        player2position = 3
                        MessageBox.Show("Welcome back")
                        BtnSellMontreal.Enabled = True
                    End If
                End If
            Else
                MessageBox.Show("You are in Montreal. The price for this land is $250 and you gain $75 if someone else is on it.", "Government of Toronto")
                BtnBuyMontreal.Enabled = True
            End If
        End If
        If Player2.Location = imagelocation(5) Then
            MessageBox.Show("You are caught stealing things, you are arrested. Cannot move For a round.", "Police Man")
            player2jail = True
            Player2.Location = imagelocation(12)
            player2position = 12
        End If
        If Player2.Location = imagelocation(6) Then
            MessageBox.Show("Your electricity does not work anymore and you asked an elctric company To fix it for you. They charge you $150", "Electricity Company Notice")
            player2money -= 150
            player2position = 6
        End If
        If Player2.Location = imagelocation(7) Then
            communitychest = rnd.Next(1, 5)
            If communitychest = 1 Then
                MessageBox.Show("You were doing community service And the coordinator liked you very much. She introduced you To Shanghai where she was born, Would you like to go?.", "Community Chest", MessageBoxButtons.YesNo)
                If DialogResult.Yes Then
                    MessageBox.Show("You are travelling to Shanghai now, the plane ticket costed you $100", "Airport")
                    player2money -= 100
                    Player2.Location = imagelocation(9)
                    player2position = 9
                ElseIf DialogResult.No Then
                    MessageBox.Show("You have decided not travel, so stayed at where you are.", "Community Chest")
                    player2money += 0
                    player2position = 7
                End If
            ElseIf communitychest = 2 Then
                MessageBox.Show("You found a wallet and gave it to Policeman, but he thinks you stole it. You are arrested.", "Community Chest")
                Player2.Location = imagelocation(12)
                player2jail = True
            ElseIf communitychest = 3 Then
                MessageBox.Show("You went to see a Raptors Game, unfortunately they lost and the ticket cost you $100", "Community Chest")
                player2money -= 100
                player2position = 7
            ElseIf communitychest = 4 Then
                MessageBox.Show("You found an empty amount cheque With signature On it, what are you going to do? Press Return to give it to the bank Or Press use to use the cheque", "Community Chest")
                Form4.Show()
                player2position = 7
            End If
        End If
        If Player2.Location = imagelocation(8) Then
            If beijingplayer1 = True Or beijingplayer2 = True Then
                If beijingplayer1 = True Then
                    If Player2.Location = imagelocation(8) Then
                        BtnBuyBeijing.Enabled = False
                        MessageBox.Show("you just stepped on player1's Beijing, you need to pay $100 rent.")
                        player2money -= 100
                        player1money += 100
                        player2position = 8
                    End If
                End If
                If beijingplayer2 = True Then
                    If Player1.Location = imagelocation(8) Then
                        BtnBuyBeijing.Enabled = False
                        player2position = 8
                        MessageBox.Show("Welcome back")
                        BtnSellBeijing.Enabled = True
                    End If
                End If
            Else
                MessageBox.Show("You are in Beijing. The price for this land is $300 and you gain $100 if someone else is on it.", "Government of Beijing")
                BtnBuyBeijing.Enabled = True
            End If
        End If
        If Player2.Location = imagelocation(9) Then
            If shanghaiplayer1 = True Or shanghaiplayer2 = True Then
                If shanghaiplayer1 = True Then
                    If Player2.Location = imagelocation(9) Then
                        BtnBuyShanghai.Enabled = False
                        MessageBox.Show("you just stepped on Player1's Shanghai, you need to pay $100 rent.")
                        player2money -= 100
                        player1money += 100
                        player2position = 9
                    End If
                End If
                If shanghaiplayer2 = True Then
                    If Player2.Location = imagelocation(9) Then
                        BtnBuyShanghai.Enabled = False
                        player2position = 9
                        MessageBox.Show("Welcome back!")
                        BtnSellShanghai.Enabled = True
                    End If
                End If
            Else
                MessageBox.Show("You are in Shanghai. The price for this land is $300 and you gain $100 if someone else is on it.", "Government of Shanghai")
                BtnBuyShanghai.Enabled = True
            End If
        End If
        If Player2.Location = imagelocation(10) Then
            chance = rnd.Next(1, 5)
            If chance = 1 Then
                MessageBox.Show("You found a wallet on the street! You gain $100!", "Chance")
                player2money += 100
                player2position = 10
            ElseIf chance = 2 Then
                MessageBox.Show("You fell on the stairs And get injured. Hopsital charge you $100", "Chance")
                player2money -= 100
                player2position = 10
            ElseIf chance = 3 Then
                MessageBox.Show("School awarded you scholarship for being so nice to others. You gain $200", "Chance")
                player2money += 200
                player2position = 10
            Else
                MessageBox.Show("You broke your neighbor's window. You are asked to buy a new one. You lose $200", "Chance")
                player2money -= 200
                player2position = 10
            End If
        End If
        If Player2.Location = imagelocation(11) Then
            MessageBox.Show("You bought too many luxurious things, therefore, the tax department are charging you $75 for showing off.", "Tax Department")
            player2money -= 75
            player2position = 11
        End If
        If Player2.Location = imagelocation(12) Then
            If player2jail = True Then
                If player2injail = False Then
                    MessageBox.Show("Player2 is in jail, cannot play for one round.")
                    player2position = 12
                    player2injail = True
                End If
            ElseIf player2jail = False Then
                MessageBox.Show("Welcome to visit the jail.")
                Me.Hide()
                Form7.Show()
                player2position = 12
            End If
        End If
        If Player2.Location = imagelocation(13) Then
            communitychest = rnd.Next(1, 5)
            If communitychest = 1 Then
                Dim communitychesttravel As Integer = MessageBox.Show("You were doing community service And the coordinator liked you very much. She introduced you To Shanghai where she was born, Would you like to go?.", "Community Chest", MessageBoxButtons.YesNo)
                If communitychesttravel = DialogResult.Yes Then
                    MessageBox.Show("You are travelling to Shanghai now, the plane ticket costed you $100", "Airport")
                    player2money -= 100
                    Player1.Location = imagelocation(9)
                    player2position = 9
                ElseIf communitychesttravel = DialogResult.No Then
                    MessageBox.Show("You have decided not travel, so stayed at where you are.", "Community Chest")
                    player2money += 0
                    player2position = 13
                End If
            ElseIf communitychest = 2 Then
                MessageBox.Show("You found a wallet And gave it To Policeman, but he thinks you stole it. You are arrested.", "Community Chest")
                Player2.Location = imagelocation(12)
                player2position = 12
            ElseIf communitychest = 3 Then
                MessageBox.Show("You went To see a Raptors Game, they lost And the ticket Is $100", "Community Chest")
                player2money -= 100
                player2position = 13
            ElseIf communitychest = 4 Then
                MessageBox.Show("You found an empty amount cheque With signature On it, what are you going to do? Press Return to give it to the bank Or Press use to use the cheque", "Community Chest")
                Form4.Show()
                Me.Hide()
                player2position = 13
            End If
        End If
        If Player2.Location = imagelocation(14) Then
            Dim result As Integer = MessageBox.Show("Do you want to visit the bank?", "Bank", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Me.Hide()
                Form6.Show()
                player2position = 14
            ElseIf result = DialogResult.No Then
                MessageBox.Show("OK!")
                player2position = 14
            End If
        End If
    End Sub
    Private Sub BtnRollDice_Click(sender As Object, e As EventArgs) Handles BtnRollDice.Click
        RollDice.Show() 'The form RollDice will be shown 
    End Sub
    Sub player1shift()
        If player1position + player1movement > 14 Then  'This is how Player1 move 
            Player1.Location = imagelocation((player1position + player1movement) - 14)
        Else
            Player1.Location = imagelocation(player1position + player1movement)
        End If
    End Sub
    Sub player2shift()
        If player2position + player2movement > 14 Then  'This is how Player2 move 
            Player2.Location = imagelocation((player2position + player2movement) - 14)
        Else
            Player2.Location = imagelocation(player2position + player2movement)
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnEndTurn.Enabled = False  'The buttons cannot be pressed
        BtnBuyToronto.Enabled = False
        BtnSellToronto.Enabled = False
        BtnBuyMontreal.Enabled = False
        BtnSellMontreal.Enabled = False
        BtnBuyShanghai.Enabled = False
        BtnSellShanghai.Enabled = False
        BtnBuyBeijing.Enabled = False
        BtnSellBeijing.Enabled = False
        turn = 1
        Me.Text = "Monopoly"
        imagelocation(1) = PictureBox1.Location 'The array how i move the Players
        imagelocation(2) = chancebox1.Location
        imagelocation(3) = Torontopic.Location
        imagelocation(4) = Montrealpic.Location
        imagelocation(5) = gotojail.Location
        imagelocation(6) = PictureBox7.Location
        imagelocation(7) = communitychest1.Location
        imagelocation(8) = beijingpic.Location
        imagelocation(9) = shanghai.Location
        imagelocation(10) = chancebox2.Location
        imagelocation(11) = PictureBox8.Location
        imagelocation(12) = jailpic1.Location
        imagelocation(13) = communitychest2.Location
        imagelocation(14) = Bank.Location
        Player1.Location = imagelocation(1)
        Player2.Location = imagelocation(1)
        If player1money < 0 Then    'If Player1 do not have money, then he loses
            MessageBox.Show("Player1 does not have any money! Game is over! Thanks for playing my game.")
            Form5.Show()
        ElseIf player1money >= 3000 Then    'If Player1 earned $3000, then he wins
            MessageBox.Show("Player1 earned $3000 and you are the winner of the game! Thanks for playing my game!")
            Form5.Show()
        ElseIf player2money >= 3000 Then    'If Player2 earned $3000, then he wins
            MessageBox.Show("Player2 earned $3000 and you are the winner of the game! Thanks for playing my game!")
            Form5.Show()
        ElseIf player2money < 0 Then    'If Player2 do not have money, then he loses
            MessageBox.Show("Player2 does not have any money. Game is over! Thanks for playing my game.")
            Form5.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Dim exitgame As Integer = MessageBox.Show("Are you sure you want to exit the game?", "Exit game?", MessageBoxButtons.YesNo)
        If exitgame = DialogResult.Yes Then 'If you want to Exit game 
            Application.Exit()
        ElseIf exitgame = DialogResult.No Then
            Me.Show()
        End If
    End Sub

    Private Sub BtnEndTurn_Click(sender As Object, e As EventArgs) Handles BtnEndTurn.Click
        BtnBuyToronto.Enabled = False
        BtnSellToronto.Enabled = False
        BtnBuyMontreal.Enabled = False
        BtnSellMontreal.Enabled = False
        BtnBuyShanghai.Enabled = False
        BtnSellShanghai.Enabled = False
        BtnBuyBeijing.Enabled = False
        BtnSellBeijing.Enabled = False
        If turn = 2 Then    'Switch turns
            turn = 1
        ElseIf turn = 1 Then
            turn = 2
        End If
        BtnRollDice.Enabled = True
        BtnEndTurn.Enabled = False
        lblturn.Text = "Player" & turn & " 's turn"
        If turn = 1 Then
            If player1injail = True Then    'If Player1 is still in Jail 
                MessageBox.Show("Player1 is still in jail.")
                player1position = 12
                BtnEndTurn.Enabled = True
                BtnRollDice.Enabled = False
                player1injail = False
            End If
        End If
        If turn = 2 Then
            If player2injail = True Then    'If Player2 is still in jail
                MessageBox.Show("Player2 is still in jail.")
                player2position = 12
                BtnEndTurn.Enabled = True
                BtnRollDice.Enabled = False
                player2injail = False
            End If
        End If
    End Sub

    Private Sub BtnBuyToronto_Click(sender As Object, e As EventArgs) Handles BtnBuyToronto.Click
        Dim buytoronto As Integer = MessageBox.Show("Are you sure that you want to buy Toronto?", "Governemnt of Toronto", MessageBoxButtons.YesNo)
        If buytoronto = DialogResult.Yes Then   'Buy toronto
            If turn = 1 Then
                torontoplayer1 = True
                player1money -= 300
                UpdatePlayer1Money()
                player1position = 3
            ElseIf turn = 2 Then
                torontoplayer2 = True
                player2money -= 300
                UpdatePlayer2Money()
                player2position = 3
            End If
            MessageBox.Show("You are now the owner of Toronto", "Government of Toronto")
        ElseIf buytoronto = DialogResult.No Then
            If turn = 1 Then
                player1money += 0
                player1position = 3
                torontoplayer1 = False
            ElseIf turn = 2 Then
                player2money += 0
                player2position = 3
                torontoplayer2 = True
            End If
            MessageBox.Show("You have decided not to buy Toronto and was asked to leave at once.", "Government of Toronto")
        End If
        BtnBuyToronto.Enabled = False
    End Sub

    Private Sub BtnSellToronto_Click(sender As Object, e As EventArgs) Handles BtnSellToronto.Click
        If torontoplayer1 = True Or torontoplayer2 = True Then  'Sell Toronto
            BtnSellToronto.Enabled = True
        End If
        Dim selltoronto As Integer = MessageBox.Show("You can sell Toronto for $300. Do you want to sell Toronto?", "Government of Toronto", MessageBoxButtons.YesNo)
        If selltoronto = DialogResult.Yes Then
            If turn = 1 Then
                torontoplayer1 = False
                player1money += 300
                UpdatePlayer1Money()
            ElseIf turn = 2 Then
                torontoplayer2 = False
                player2money += 300
                UpdatePlayer2Money()
            End If
        ElseIf selltoronto = DialogResult.No Then
            If turn = 1 Then
                torontoplayer1 = True
                player1money += 0
            ElseIf turn = 2 Then
                torontoplayer2 = True
                player2money += 0
            End If
        End If
        BtnSellToronto.Enabled = False
    End Sub

    Private Sub BtnSellMontreal_Click(sender As Object, e As EventArgs) Handles BtnSellMontreal.Click
        If montrealplayer1 = True Or montrealplayer2 = True Then    'Sell Toronto
            BtnSellMontreal.Enabled = True
        End If
        Dim sellmontreal As Integer = MessageBox.Show("You can sell Montreal for $300. Do you want to sell Montreal", "Government of Montreal", MessageBoxButtons.YesNo)
        If sellmontreal = DialogResult.Yes Then
            If turn = 1 Then
                montrealplayer1 = False
                player1money += 300
                UpdatePlayer1Money()
            ElseIf turn = 2 Then
                montrealplayer2 = False
                player2money += 300
                UpdatePlayer2Money()
            End If
        ElseIf sellmontreal = DialogResult.No Then
            If turn = 1 Then
                montrealplayer1 = True
                player1money += 0
            ElseIf turn = 2 Then
                montrealplayer2 = True
                player2money += 0
            End If
        End If
        BtnSellMontreal.Enabled = False
    End Sub

    Private Sub BtnSellBeijing_Click(sender As Object, e As EventArgs) Handles BtnSellBeijing.Click
        If beijingplayer1 = True Or beijingplayer2 = True Then  'Sell Beijing
            BtnSellBeijing.Enabled = True
        End If
        Dim sellbeijing As Integer = MessageBox.Show("You can sell Beijing for $300. Do you want to sell Beijing?", "Government of Beijing", MessageBoxButtons.YesNo)
        If sellbeijing = DialogResult.Yes Then
            If turn = 1 Then
                beijingplayer1 = False
                player1money += 300
                UpdatePlayer1Money()
            ElseIf turn = 2 Then
                beijingplayer2 = False
                player2money += 300
                UpdatePlayer2Money()
            End If
        ElseIf sellbeijing = DialogResult.No Then
            If turn = 1 Then
                beijingplayer1 = True
                player1money += 0
            ElseIf turn = 2 Then
                beijingplayer2 = True
                player2money += 0
            End If
        End If
        BtnSellBeijing.Enabled = False
    End Sub

    Private Sub BtnBuyBeijing_Click(sender As Object, e As EventArgs) Handles BtnBuyBeijing.Click
        Dim buybeijing As Integer = MessageBox.Show("Are you sure that you want to buy Beijing?", "Governemnt of Beijing", MessageBoxButtons.YesNo)
        If buybeijing = DialogResult.Yes Then   'Buy Beijing
            If turn = 1 Then
                beijingplayer1 = True
                player1money -= 300
                UpdatePlayer1Money()
                player1position = 8
            ElseIf turn = 2 Then
                beijingplayer2 = True
                player2money -= 300
                UpdatePlayer2Money()
                player2position = 8
            End If
            MessageBox.Show("You are now the owner of Beijing", "Government of Beijing")
        ElseIf buybeijing = DialogResult.No Then
            If turn = 1 Then
                player1money += 0
                player1position = 8
                beijingplayer1 = False
            ElseIf turn = 2 Then
                player2money += 0
                player2position = 8
                beijingplayer2 = True
            End If
            MessageBox.Show("You have decided not to buy Beijing and was asked to leave at once.", "Government of Beijing")
        End If
        BtnBuyBeijing.Enabled = False
    End Sub

    Private Sub BtnSellShanghai_Click(sender As Object, e As EventArgs) Handles BtnSellShanghai.Click
        If shanghaiplayer1 = True Or shanghaiplayer2 = True Then    'Sell Shanghai
            BtnSellShanghai.Enabled = True
        End If
        Dim sellshanghai As Integer = MessageBox.Show("You can sell Shanghai for $300. Do you want to sell Shanghai?", "Government of Shanghai", MessageBoxButtons.YesNo)
        If sellshanghai = DialogResult.Yes Then
            If turn = 1 Then
                shanghaiplayer1 = False
                player1money += 300
                UpdatePlayer1Money()
            ElseIf turn = 2 Then
                shanghaiplayer2 = False
                player2money += 300
                UpdatePlayer2Money()
            End If
        ElseIf sellshanghai = DialogResult.No Then
            If turn = 1 Then
                shanghaiplayer1 = True
                player1money += 0
            ElseIf turn = 2 Then
                shanghaiplayer2 = True
                player2money += 0
            End If
        End If
        BtnSellShanghai.Enabled = False
    End Sub

    Private Sub BtnBuyMontreal_Click(sender As Object, e As EventArgs) Handles BtnBuyMontreal.Click
        Dim buymontreal As Integer = MessageBox.Show("Are you sure that you want to buy Montreal?", "Governemnt of Montreal", MessageBoxButtons.YesNo)
        If buymontreal = DialogResult.Yes Then  'Buy Montreal
            If turn = 1 Then
                montrealplayer1 = True
                player1money -= 250
                UpdatePlayer1Money()
                player1position = 4
            ElseIf turn = 2 Then
                montrealplayer2 = True
                player2money -= 250
                UpdatePlayer2Money()
                player2position = 4
            End If
            MessageBox.Show("You are now the owner of Montreal", "Government of Montreal")
        ElseIf buymontreal = DialogResult.No Then
            If turn = 1 Then
                player1money += 0
                player1position = 4
                montrealplayer1 = False
            ElseIf turn = 2 Then
                player2money += 0
                player2position = 4
                montrealplayer2 = True
            End If
            MessageBox.Show("You have decided not to buy Montreal and was asked to leave at once.", "Government of Montreal")
        End If
        BtnBuyMontreal.Enabled = False
    End Sub

    Private Sub BtnBuyShanghai_Click(sender As Object, e As EventArgs) Handles BtnBuyShanghai.Click
        Dim buyshanghai As Integer = MessageBox.Show("Are you sure that you want to buy Shanghai?", "Governemnt of Shanghai", MessageBoxButtons.YesNo)
        If buyshanghai = DialogResult.Yes Then  'Buy Shanghai
            If turn = 1 Then
                shanghaiplayer1 = True
                player1money -= 300
                UpdatePlayer1Money()
                player1position = 9
            ElseIf turn = 2 Then
                shanghaiplayer2 = True
                player2money -= 300
                UpdatePlayer2Money()
                player2position = 9
            End If
            MessageBox.Show("You are now the owner of Shanghai", "Government of Shanghai")
        ElseIf buyshanghai = DialogResult.No Then
            If turn = 1 Then
                player1money += 0
                player1position = 9
                shanghaiplayer1 = False
            ElseIf turn = 2 Then
                player2money += 0
                player2position = 9
                shanghaiplayer2 = True
            End If
            MessageBox.Show("You have decided not to buy Shanghai and was asked to leave at once.", "Government of Shanghai")
        End If
        BtnBuyShanghai.Enabled = False
    End Sub

    Public Sub ShowMeFromChild()
        Me.Show()   'Get the value from roll and use it for movement 
        If RollDice.judgement = True Then
            If turn = 1 Then
                player1movement = RollDice.roll
                player1shift()
                RollDice.Hide()
                Afterrolldiceplayer1()
                UpdatePlayer1Money()
            ElseIf turn = 2 Then
                player2movement = RollDice.roll
                player2shift()
                RollDice.Hide()
                Afterrolldiceplayer2()
                UpdatePlayer2Money()
            End If
            BtnRollDice.Enabled = False
            BtnEndTurn.Enabled = True
        End If
    End Sub

    Public Sub UpdatePlayer1Money()
        lblplayermoney1.Text = "Player1 Money: $" & player1money
    End Sub

    Public Sub UpdatePlayer2Money()
        lblplayermoney2.Text = "Player2 Money: $" & player2money
    End Sub

End Class