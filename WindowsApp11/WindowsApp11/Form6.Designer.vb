<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Moneytaking = New System.Windows.Forms.NumericUpDown()
        Me.lblaccountmoney = New System.Windows.Forms.Label()
        Me.BtnOkay = New System.Windows.Forms.Button()
        Me.lbltotalmoney = New System.Windows.Forms.Label()
        CType(Me.Moneytaking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Moneytaking
        '
        Me.Moneytaking.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Moneytaking.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Moneytaking.Location = New System.Drawing.Point(292, 229)
        Me.Moneytaking.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Moneytaking.Name = "Moneytaking"
        Me.Moneytaking.Size = New System.Drawing.Size(133, 32)
        Me.Moneytaking.TabIndex = 0
        Me.Moneytaking.ThousandsSeparator = True
        Me.Moneytaking.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'lblaccountmoney
        '
        Me.lblaccountmoney.AutoSize = True
        Me.lblaccountmoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblaccountmoney.Location = New System.Drawing.Point(160, 134)
        Me.lblaccountmoney.Name = "lblaccountmoney"
        Me.lblaccountmoney.Size = New System.Drawing.Size(472, 26)
        Me.lblaccountmoney.TabIndex = 1
        Me.lblaccountmoney.Text = "Your total money in your bank account is $1000"
        '
        'BtnOkay
        '
        Me.BtnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.BtnOkay.Location = New System.Drawing.Point(292, 286)
        Me.BtnOkay.Name = "BtnOkay"
        Me.BtnOkay.Size = New System.Drawing.Size(101, 40)
        Me.BtnOkay.TabIndex = 2
        Me.BtnOkay.Text = "Okay"
        Me.BtnOkay.UseVisualStyleBackColor = True
        '
        'lbltotalmoney
        '
        Me.lbltotalmoney.AutoSize = True
        Me.lbltotalmoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lbltotalmoney.Location = New System.Drawing.Point(165, 186)
        Me.lbltotalmoney.Name = "lbltotalmoney"
        Me.lbltotalmoney.Size = New System.Drawing.Size(206, 26)
        Me.lbltotalmoney.TabIndex = 3
        Me.lbltotalmoney.Text = "Your total money is "
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp11.My.Resources.Resources.bank
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbltotalmoney)
        Me.Controls.Add(Me.BtnOkay)
        Me.Controls.Add(Me.lblaccountmoney)
        Me.Controls.Add(Me.Moneytaking)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.Moneytaking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Moneytaking As NumericUpDown
    Friend WithEvents lblaccountmoney As Label
    Friend WithEvents BtnOkay As Button
    Friend WithEvents lbltotalmoney As Label
End Class
