<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class You_spin_my_head_right_round
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.positionLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cColor = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.Label()
        Me.TextboxPort = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.currpos = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.color1Label = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(85, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "set start color"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'positionLabel
        '
        Me.positionLabel.AutoSize = True
        Me.positionLabel.Location = New System.Drawing.Point(263, 24)
        Me.positionLabel.Name = "positionLabel"
        Me.positionLabel.Size = New System.Drawing.Size(0, 17)
        Me.positionLabel.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cColor)
        Me.Panel1.Controls.Add(Me.status)
        Me.Panel1.Controls.Add(Me.TextboxPort)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.currpos)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.color1Label)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.positionLabel)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 197)
        Me.Panel1.TabIndex = 5
        '
        'cColor
        '
        Me.cColor.AutoSize = True
        Me.cColor.Location = New System.Drawing.Point(14, 110)
        Me.cColor.Name = "cColor"
        Me.cColor.Size = New System.Drawing.Size(56, 17)
        Me.cColor.TabIndex = 13
        Me.cColor.Text = "            "
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(13, 139)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(59, 17)
        Me.status.TabIndex = 12
        Me.status.Text = "set up..."
        '
        'TextboxPort
        '
        Me.TextboxPort.Location = New System.Drawing.Point(167, 136)
        Me.TextboxPort.Name = "TextboxPort"
        Me.TextboxPort.Size = New System.Drawing.Size(58, 22)
        Me.TextboxPort.TabIndex = 11
        Me.TextboxPort.Text = "COM3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "SerialPort"
        '
        'currpos
        '
        Me.currpos.AutoSize = True
        Me.currpos.Location = New System.Drawing.Point(14, 76)
        Me.currpos.Name = "currpos"
        Me.currpos.Size = New System.Drawing.Size(51, 17)
        Me.currpos.TabIndex = 9
        Me.currpos.Text = "Label1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(85, 56)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(272, 71)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = "11"
        '
        'color1Label
        '
        Me.color1Label.AutoSize = True
        Me.color1Label.Location = New System.Drawing.Point(214, 24)
        Me.color1Label.Name = "color1Label"
        Me.color1Label.Size = New System.Drawing.Size(40, 17)
        Me.color1Label.TabIndex = 6
        Me.color1Label.Text = "        "
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(251, 133)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "start listen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.AutoSpin.My.Resources.Resources.cross_edit
        Me.PictureBox1.Location = New System.Drawing.Point(10, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "stop"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'You_spin_my_head_right_round
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(367, 169)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "You_spin_my_head_right_round"
        Me.Opacity = 0.8R
        Me.Text = "You spin my head right round"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents positionLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents color1Label As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents currpos As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TextboxPort As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents cColor As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
