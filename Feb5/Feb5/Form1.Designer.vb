<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bReset = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.gButton = New System.Windows.Forms.Button()
        Me.bNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.gNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.gReset = New System.Windows.Forms.Button()
        Me.oReset = New System.Windows.Forms.Button()
        Me.oNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.oButton = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ClickerControl3 = New Feb5.ClickerControl()
        Me.ClickerControl2 = New Feb5.ClickerControl()
        Me.ClickerControl1 = New Feb5.ClickerControl()
        CType(Me.bNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bButton
        '
        Me.bButton.Location = New System.Drawing.Point(36, 33)
        Me.bButton.Name = "bButton"
        Me.bButton.Size = New System.Drawing.Size(75, 23)
        Me.bButton.TabIndex = 0
        Me.bButton.Text = "Boy"
        Me.bButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(36, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 22)
        Me.TextBox1.TabIndex = 1
        '
        'bReset
        '
        Me.bReset.Location = New System.Drawing.Point(36, 118)
        Me.bReset.Name = "bReset"
        Me.bReset.Size = New System.Drawing.Size(75, 23)
        Me.bReset.TabIndex = 2
        Me.bReset.Text = "Reset"
        Me.bReset.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(149, 62)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 22)
        Me.TextBox2.TabIndex = 3
        '
        'gButton
        '
        Me.gButton.Location = New System.Drawing.Point(149, 33)
        Me.gButton.Name = "gButton"
        Me.gButton.Size = New System.Drawing.Size(75, 23)
        Me.gButton.TabIndex = 4
        Me.gButton.Text = "Girl"
        Me.gButton.UseVisualStyleBackColor = True
        '
        'bNumericUpDown
        '
        Me.bNumericUpDown.Location = New System.Drawing.Point(36, 90)
        Me.bNumericUpDown.Name = "bNumericUpDown"
        Me.bNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.bNumericUpDown.TabIndex = 5
        '
        'gNumericUpDown
        '
        Me.gNumericUpDown.Location = New System.Drawing.Point(149, 90)
        Me.gNumericUpDown.Name = "gNumericUpDown"
        Me.gNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.gNumericUpDown.TabIndex = 6
        '
        'gReset
        '
        Me.gReset.Location = New System.Drawing.Point(149, 118)
        Me.gReset.Name = "gReset"
        Me.gReset.Size = New System.Drawing.Size(75, 23)
        Me.gReset.TabIndex = 7
        Me.gReset.Text = "Reset"
        Me.gReset.UseVisualStyleBackColor = True
        '
        'oReset
        '
        Me.oReset.Location = New System.Drawing.Point(259, 118)
        Me.oReset.Name = "oReset"
        Me.oReset.Size = New System.Drawing.Size(75, 23)
        Me.oReset.TabIndex = 11
        Me.oReset.Text = "Reset"
        Me.oReset.UseVisualStyleBackColor = True
        '
        'oNumericUpDown
        '
        Me.oNumericUpDown.Location = New System.Drawing.Point(259, 90)
        Me.oNumericUpDown.Name = "oNumericUpDown"
        Me.oNumericUpDown.Size = New System.Drawing.Size(75, 22)
        Me.oNumericUpDown.TabIndex = 10
        '
        'oButton
        '
        Me.oButton.Location = New System.Drawing.Point(259, 33)
        Me.oButton.Name = "oButton"
        Me.oButton.Size = New System.Drawing.Size(75, 23)
        Me.oButton.TabIndex = 9
        Me.oButton.Text = "Other"
        Me.oButton.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(259, 62)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(75, 22)
        Me.TextBox3.TabIndex = 8
        '
        'ClickerControl3
        '
        Me.ClickerControl3.BackColor = System.Drawing.Color.Salmon
        Me.ClickerControl3.increment = 5
        Me.ClickerControl3.Location = New System.Drawing.Point(259, 266)
        Me.ClickerControl3.Name = "ClickerControl3"
        Me.ClickerControl3.Size = New System.Drawing.Size(150, 150)
        Me.ClickerControl3.TabIndex = 14
        '
        'ClickerControl2
        '
        Me.ClickerControl2.BackColor = System.Drawing.Color.LightBlue
        Me.ClickerControl2.increment = 1
        Me.ClickerControl2.Location = New System.Drawing.Point(434, 266)
        Me.ClickerControl2.Name = "ClickerControl2"
        Me.ClickerControl2.Size = New System.Drawing.Size(150, 150)
        Me.ClickerControl2.TabIndex = 13
        '
        'ClickerControl1
        '
        Me.ClickerControl1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClickerControl1.increment = 1
        Me.ClickerControl1.Location = New System.Drawing.Point(611, 266)
        Me.ClickerControl1.Name = "ClickerControl1"
        Me.ClickerControl1.Size = New System.Drawing.Size(150, 150)
        Me.ClickerControl1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClickerControl3)
        Me.Controls.Add(Me.ClickerControl2)
        Me.Controls.Add(Me.ClickerControl1)
        Me.Controls.Add(Me.oReset)
        Me.Controls.Add(Me.oNumericUpDown)
        Me.Controls.Add(Me.oButton)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.gReset)
        Me.Controls.Add(Me.gNumericUpDown)
        Me.Controls.Add(Me.bNumericUpDown)
        Me.Controls.Add(Me.gButton)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.bReset)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.bNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents bReset As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents gButton As Button
    Friend WithEvents bNumericUpDown As NumericUpDown
    Friend WithEvents gNumericUpDown As NumericUpDown
    Friend WithEvents gReset As Button
    Friend WithEvents oReset As Button
    Friend WithEvents oNumericUpDown As NumericUpDown
    Friend WithEvents oButton As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ClickerControl1 As ClickerControl
    Friend WithEvents ClickerControl2 As ClickerControl
    Friend WithEvents ClickerControl3 As ClickerControl
End Class
