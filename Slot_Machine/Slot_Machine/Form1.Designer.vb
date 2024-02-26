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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.r1Label = New System.Windows.Forms.Label()
        Me.r2Label = New System.Windows.Forms.Label()
        Me.r3Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.doButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReelControl3 = New Slot_Machine.ReelControl()
        Me.ReelControl1 = New Slot_Machine.ReelControl()
        Me.ReelControl2 = New Slot_Machine.ReelControl()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(27, 393)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(462, 100)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Redeem Win! (+$5)"
        Me.Button2.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(352, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(137, 44)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(269, 278)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 58)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'doButton
        '
        Me.doButton.Location = New System.Drawing.Point(269, 342)
        Me.doButton.Name = "doButton"
        Me.doButton.Size = New System.Drawing.Size(64, 28)
        Me.doButton.TabIndex = 12
        Me.doButton.Text = "Dollar"
        Me.doButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(352, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(137, 44)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(27, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 100)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Spin! (-$1)"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.ClientSize = New System.Drawing.Size(537, 526)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.doButton)
        Me.Controls.Add(Me.r3Label)
        Me.Controls.Add(Me.r2Label)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl1)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.r1Label)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents r1Label As Label
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents r2Label As Label
    Friend WithEvents r3Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents doButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
