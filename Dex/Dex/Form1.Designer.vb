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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Field1 = New System.Windows.Forms.TextBox()
        Me.Field2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Field3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Field4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Field5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(491, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FIleToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(132, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Field1
        '
        Me.Field1.Location = New System.Drawing.Point(132, 182)
        Me.Field1.Name = "Field1"
        Me.Field1.Size = New System.Drawing.Size(286, 27)
        Me.Field1.TabIndex = 3
        '
        'Field2
        '
        Me.Field2.Location = New System.Drawing.Point(132, 215)
        Me.Field2.Name = "Field2"
        Me.Field2.Size = New System.Drawing.Size(286, 27)
        Me.Field2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Released"
        '
        'Field3
        '
        Me.Field3.Location = New System.Drawing.Point(132, 248)
        Me.Field3.Name = "Field3"
        Me.Field3.Size = New System.Drawing.Size(286, 27)
        Me.Field3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Purpose"
        '
        'Field4
        '
        Me.Field4.Location = New System.Drawing.Point(132, 281)
        Me.Field4.Name = "Field4"
        Me.Field4.Size = New System.Drawing.Size(286, 27)
        Me.Field4.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Developer"
        '
        'Field5
        '
        Me.Field5.Location = New System.Drawing.Point(132, 314)
        Me.Field5.Name = "Field5"
        Me.Field5.Size = New System.Drawing.Size(286, 27)
        Me.Field5.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Latest Version"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FirstButton
        '
        Me.FirstButton.Location = New System.Drawing.Point(324, 42)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(94, 29)
        Me.FirstButton.TabIndex = 12
        Me.FirstButton.Text = "First"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'PrevButton
        '
        Me.PrevButton.Location = New System.Drawing.Point(324, 112)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(94, 29)
        Me.PrevButton.TabIndex = 13
        Me.PrevButton.Text = "Prev"
        Me.PrevButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(324, 77)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(94, 29)
        Me.NextButton.TabIndex = 14
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'LastButton
        '
        Me.LastButton.Location = New System.Drawing.Point(324, 147)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(94, 29)
        Me.LastButton.TabIndex = 15
        Me.LastButton.Text = "Last"
        Me.LastButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 401)
        Me.Controls.Add(Me.LastButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.Field5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Field4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Field3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Field2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Field1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Field1 As TextBox
    Friend WithEvents Field2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Field3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Field4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Field5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FirstButton As Button
    Friend WithEvents PrevButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents LastButton As Button
End Class
