<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.spinButton = New System.Windows.Forms.Button()
        Me.r1Label = New System.Windows.Forms.Label()
        Me.r2Label = New System.Windows.Forms.Label()
        Me.r3Label = New System.Windows.Forms.Label()
        Me.ReelControl3 = New Slot_Machine.ReelControl()
        Me.ReelControl1 = New Slot_Machine.ReelControl()
        Me.ReelControl2 = New Slot_Machine.ReelControl()
        Me.SuspendLayout()
        '
        'spinButton
        '
        Me.spinButton.BackColor = System.Drawing.SystemColors.Info
        Me.spinButton.Font = New System.Drawing.Font("Century Gothic", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spinButton.Location = New System.Drawing.Point(142, 278)
        Me.spinButton.Name = "spinButton"
        Me.spinButton.Size = New System.Drawing.Size(234, 100)
        Me.spinButton.TabIndex = 1
        Me.spinButton.Text = "Spin!"
        Me.spinButton.UseVisualStyleBackColor = False
        '
        'r1Label
        '
        Me.r1Label.AutoSize = True
        Me.r1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1Label.Location = New System.Drawing.Point(67, 218)
        Me.r1Label.Name = "r1Label"
        Me.r1Label.Size = New System.Drawing.Size(71, 25)
        Me.r1Label.TabIndex = 2
        Me.r1Label.Text = "Label1"
        Me.r1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r2Label
        '
        Me.r2Label.AutoSize = True
        Me.r2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2Label.Location = New System.Drawing.Point(223, 218)
        Me.r2Label.Name = "r2Label"
        Me.r2Label.Size = New System.Drawing.Size(71, 25)
        Me.r2Label.TabIndex = 6
        Me.r2Label.Text = "Label2"
        Me.r2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'r3Label
        '
        Me.r3Label.AutoSize = True
        Me.r3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r3Label.Location = New System.Drawing.Point(379, 218)
        Me.r3Label.Name = "r3Label"
        Me.r3Label.Size = New System.Drawing.Size(71, 25)
        Me.r3Label.TabIndex = 7
        Me.r3Label.Text = "Label3"
        Me.r3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReelControl3
        '
        Me.ReelControl3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ReelControl3.itemValue = 0
        Me.ReelControl3.Location = New System.Drawing.Point(339, 65)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl3.spinTime = 2000
        Me.ReelControl3.TabIndex = 5
        '
        'ReelControl1
        '
        Me.ReelControl1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ReelControl1.itemValue = 0
        Me.ReelControl1.Location = New System.Drawing.Point(27, 65)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl1.spinTime = 2000
        Me.ReelControl1.TabIndex = 4
        '
        'ReelControl2
        '
        Me.ReelControl2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ReelControl2.itemValue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(183, 65)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl2.spinTime = 2000
        Me.ReelControl2.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.r3Label)
        Me.Controls.Add(Me.r2Label)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl1)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.r1Label)
        Me.Controls.Add(Me.spinButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents spinButton As Button
    Friend WithEvents r1Label As Label
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents r2Label As Label
    Friend WithEvents r3Label As Label
End Class
