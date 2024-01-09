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
        Me.RedButton = New System.Windows.Forms.Button()
        Me.BlueButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RedButton
        '
        Me.RedButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RedButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RedButton.Location = New System.Drawing.Point(126, 157)
        Me.RedButton.Name = "RedButton"
        Me.RedButton.Size = New System.Drawing.Size(201, 75)
        Me.RedButton.TabIndex = 0
        Me.RedButton.Text = "Red"
        Me.RedButton.UseVisualStyleBackColor = True
        '
        'BlueButton
        '
        Me.BlueButton.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BlueButton.ForeColor = System.Drawing.Color.Blue
        Me.BlueButton.Location = New System.Drawing.Point(460, 157)
        Me.BlueButton.Name = "BlueButton"
        Me.BlueButton.Size = New System.Drawing.Size(207, 75)
        Me.BlueButton.TabIndex = 1
        Me.BlueButton.Text = "Blue"
        Me.BlueButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BlueButton)
        Me.Controls.Add(Me.RedButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RedButton As Button
    Friend WithEvents BlueButton As Button
End Class
