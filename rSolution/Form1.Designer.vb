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
        Me.intrBtn = New System.Windows.Forms.Button()
        Me.lstB = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'intrBtn
        '
        Me.intrBtn.Location = New System.Drawing.Point(33, 370)
        Me.intrBtn.Name = "intrBtn"
        Me.intrBtn.Size = New System.Drawing.Size(224, 50)
        Me.intrBtn.TabIndex = 0
        Me.intrBtn.Text = "Introduzir"
        Me.intrBtn.UseVisualStyleBackColor = True
        '
        'lstB
        '
        Me.lstB.FormattingEnabled = True
        Me.lstB.ItemHeight = 20
        Me.lstB.Location = New System.Drawing.Point(288, 12)
        Me.lstB.Name = "lstB"
        Me.lstB.Size = New System.Drawing.Size(500, 424)
        Me.lstB.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstB)
        Me.Controls.Add(Me.intrBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents intrBtn As Button
    Friend WithEvents lstB As ListBox
End Class
