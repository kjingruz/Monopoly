<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollDice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.BtnRollDice = New System.Windows.Forms.Button()
        Me.PicDice6 = New System.Windows.Forms.PictureBox()
        Me.PicDice2 = New System.Windows.Forms.PictureBox()
        Me.PicDice1 = New System.Windows.Forms.PictureBox()
        Me.PicDice3 = New System.Windows.Forms.PictureBox()
        Me.PicDice5 = New System.Windows.Forms.PictureBox()
        Me.PicDice4 = New System.Windows.Forms.PictureBox()
        CType(Me.PicDice6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDice5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDice4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(711, 162)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(54, 58)
        Me.lbltotal.TabIndex = 0
        Me.lbltotal.Text = "0"
        '
        'BtnRollDice
        '
        Me.BtnRollDice.Font = New System.Drawing.Font("Showcard Gothic", 14.0!)
        Me.BtnRollDice.Location = New System.Drawing.Point(336, 349)
        Me.BtnRollDice.Name = "BtnRollDice"
        Me.BtnRollDice.Size = New System.Drawing.Size(209, 54)
        Me.BtnRollDice.TabIndex = 1
        Me.BtnRollDice.Text = "Roll Dice"
        Me.BtnRollDice.UseVisualStyleBackColor = True
        '
        'PicDice6
        '
        Me.PicDice6.Image = Global.WindowsApp11.My.Resources.Resources.dice6
        Me.PicDice6.Location = New System.Drawing.Point(336, 64)
        Me.PicDice6.Name = "PicDice6"
        Me.PicDice6.Size = New System.Drawing.Size(213, 236)
        Me.PicDice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDice6.TabIndex = 2
        Me.PicDice6.TabStop = False
        '
        'PicDice2
        '
        Me.PicDice2.Image = Global.WindowsApp11.My.Resources.Resources.dice2
        Me.PicDice2.Location = New System.Drawing.Point(336, 62)
        Me.PicDice2.Name = "PicDice2"
        Me.PicDice2.Size = New System.Drawing.Size(213, 236)
        Me.PicDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDice2.TabIndex = 4
        Me.PicDice2.TabStop = False
        '
        'PicDice1
        '
        Me.PicDice1.Image = Global.WindowsApp11.My.Resources.Resources.dice1
        Me.PicDice1.Location = New System.Drawing.Point(336, 62)
        Me.PicDice1.Name = "PicDice1"
        Me.PicDice1.Size = New System.Drawing.Size(213, 235)
        Me.PicDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDice1.TabIndex = 6
        Me.PicDice1.TabStop = False
        '
        'PicDice3
        '
        Me.PicDice3.Image = Global.WindowsApp11.My.Resources.Resources.dice3
        Me.PicDice3.Location = New System.Drawing.Point(336, 61)
        Me.PicDice3.Name = "PicDice3"
        Me.PicDice3.Size = New System.Drawing.Size(213, 235)
        Me.PicDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDice3.TabIndex = 7
        Me.PicDice3.TabStop = False
        '
        'PicDice5
        '
        Me.PicDice5.Image = Global.WindowsApp11.My.Resources.Resources.dice5
        Me.PicDice5.Location = New System.Drawing.Point(336, 64)
        Me.PicDice5.Name = "PicDice5"
        Me.PicDice5.Size = New System.Drawing.Size(213, 235)
        Me.PicDice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDice5.TabIndex = 8
        Me.PicDice5.TabStop = False
        '
        'PicDice4
        '
        Me.PicDice4.Image = Global.WindowsApp11.My.Resources.Resources.dice4
        Me.PicDice4.Location = New System.Drawing.Point(336, 66)
        Me.PicDice4.Name = "PicDice4"
        Me.PicDice4.Size = New System.Drawing.Size(213, 233)
        Me.PicDice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDice4.TabIndex = 11
        Me.PicDice4.TabStop = False
        '
        'RollDice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PicDice4)
        Me.Controls.Add(Me.PicDice5)
        Me.Controls.Add(Me.PicDice3)
        Me.Controls.Add(Me.PicDice1)
        Me.Controls.Add(Me.PicDice2)
        Me.Controls.Add(Me.PicDice6)
        Me.Controls.Add(Me.BtnRollDice)
        Me.Controls.Add(Me.lbltotal)
        Me.Name = "RollDice"
        Me.Text = "Roll Dice"
        CType(Me.PicDice6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDice5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDice4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltotal As Label
    Friend WithEvents BtnRollDice As Button
    Friend WithEvents PicDice6 As PictureBox
    Friend WithEvents PicDice2 As PictureBox
    Friend WithEvents PicDice1 As PictureBox
    Friend WithEvents PicDice3 As PictureBox
    Friend WithEvents PicDice5 As PictureBox
    Friend WithEvents PicDice4 As PictureBox
End Class
