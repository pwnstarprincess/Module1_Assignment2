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
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.CustomerBox = New System.Windows.Forms.TextBox()
        Me.LaborBox = New System.Windows.Forms.TextBox()
        Me.TotalOutputBox = New System.Windows.Forms.TextBox()
        Me.SuppliesBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(278, 67)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(96, 37)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "Display Bill"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'CustomerBox
        '
        Me.CustomerBox.Location = New System.Drawing.Point(108, 11)
        Me.CustomerBox.Name = "CustomerBox"
        Me.CustomerBox.Size = New System.Drawing.Size(154, 20)
        Me.CustomerBox.TabIndex = 0
        '
        'LaborBox
        '
        Me.LaborBox.Location = New System.Drawing.Point(162, 37)
        Me.LaborBox.Name = "LaborBox"
        Me.LaborBox.Size = New System.Drawing.Size(100, 20)
        Me.LaborBox.TabIndex = 1
        '
        'TotalOutputBox
        '
        Me.TotalOutputBox.Location = New System.Drawing.Point(74, 120)
        Me.TotalOutputBox.Multiline = True
        Me.TotalOutputBox.Name = "TotalOutputBox"
        Me.TotalOutputBox.ReadOnly = True
        Me.TotalOutputBox.Size = New System.Drawing.Size(222, 74)
        Me.TotalOutputBox.TabIndex = 4
        '
        'SuppliesBox
        '
        Me.SuppliesBox.Location = New System.Drawing.Point(162, 67)
        Me.SuppliesBox.Name = "SuppliesBox"
        Me.SuppliesBox.Size = New System.Drawing.Size(100, 20)
        Me.SuppliesBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customer:  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hours of Labor:  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cost of Parts and Supplies:  "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 237)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SuppliesBox)
        Me.Controls.Add(Me.TotalOutputBox)
        Me.Controls.Add(Me.LaborBox)
        Me.Controls.Add(Me.CustomerBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Name = "Form1"
        Me.Text = "Auto Repair"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalculateButton As Button
    Friend WithEvents CustomerBox As TextBox
    Friend WithEvents LaborBox As TextBox
    Friend WithEvents TotalOutputBox As TextBox
    Friend WithEvents SuppliesBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
