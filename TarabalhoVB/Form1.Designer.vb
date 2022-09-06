<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTrabalho
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ex3Panel = New System.Windows.Forms.Panel()
        Me.lblMaisVogais = New System.Windows.Forms.Label()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.btnMaisVogais = New System.Windows.Forms.Button()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstProcura = New System.Windows.Forms.ListBox()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstNomes = New System.Windows.Forms.ListBox()
        Me.txtNomes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ex3Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ex3Panel
        '
        Me.ex3Panel.Controls.Add(Me.lblMaisVogais)
        Me.ex3Panel.Controls.Add(Me.lstResult)
        Me.ex3Panel.Controls.Add(Me.btnMaisVogais)
        Me.ex3Panel.Controls.Add(Me.btnInserir)
        Me.ex3Panel.Controls.Add(Me.Label3)
        Me.ex3Panel.Controls.Add(Me.lstProcura)
        Me.ex3Panel.Controls.Add(Me.btnProcurar)
        Me.ex3Panel.Controls.Add(Me.Label2)
        Me.ex3Panel.Controls.Add(Me.lstNomes)
        Me.ex3Panel.Controls.Add(Me.txtNomes)
        Me.ex3Panel.Controls.Add(Me.Label1)
        Me.ex3Panel.Location = New System.Drawing.Point(12, 12)
        Me.ex3Panel.Name = "ex3Panel"
        Me.ex3Panel.Size = New System.Drawing.Size(788, 426)
        Me.ex3Panel.TabIndex = 2
        '
        'lblMaisVogais
        '
        Me.lblMaisVogais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaisVogais.Location = New System.Drawing.Point(235, 75)
        Me.lblMaisVogais.Name = "lblMaisVogais"
        Me.lblMaisVogais.Size = New System.Drawing.Size(229, 47)
        Me.lblMaisVogais.TabIndex = 12
        Me.lblMaisVogais.Text = "MAIS VOGAIS"
        Me.lblMaisVogais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMaisVogais.Visible = False
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 20
        Me.lstResult.Location = New System.Drawing.Point(235, 103)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(229, 224)
        Me.lstResult.TabIndex = 11
        Me.lstResult.Visible = False
        '
        'btnMaisVogais
        '
        Me.btnMaisVogais.Location = New System.Drawing.Point(3, 333)
        Me.btnMaisVogais.Name = "btnMaisVogais"
        Me.btnMaisVogais.Size = New System.Drawing.Size(461, 29)
        Me.btnMaisVogais.TabIndex = 10
        Me.btnMaisVogais.Text = "Palavra com Mais Vogais do Nome"
        Me.btnMaisVogais.UseVisualStyleBackColor = True
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(3, 368)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(461, 29)
        Me.btnInserir.TabIndex = 7
        Me.btnInserir.Text = "Inserir Nomes"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(470, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 52)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PROCURA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstProcura
        '
        Me.lstProcura.FormattingEnabled = True
        Me.lstProcura.ItemHeight = 20
        Me.lstProcura.Location = New System.Drawing.Point(470, 33)
        Me.lstProcura.Name = "lstProcura"
        Me.lstProcura.Size = New System.Drawing.Size(150, 364)
        Me.lstProcura.TabIndex = 5
        '
        'btnProcurar
        '
        Me.btnProcurar.Location = New System.Drawing.Point(14, 43)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(450, 29)
        Me.btnProcurar.TabIndex = 4
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(626, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 52)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOMES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstNomes
        '
        Me.lstNomes.FormattingEnabled = True
        Me.lstNomes.ItemHeight = 20
        Me.lstNomes.Location = New System.Drawing.Point(626, 33)
        Me.lstNomes.Name = "lstNomes"
        Me.lstNomes.Size = New System.Drawing.Size(150, 364)
        Me.lstNomes.TabIndex = 2
        '
        'txtNomes
        '
        Me.txtNomes.Location = New System.Drawing.Point(132, 10)
        Me.txtNomes.Name = "txtNomes"
        Me.txtNomes.Size = New System.Drawing.Size(332, 27)
        Me.txtNomes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Procurar Nome:"
        '
        'FrmTrabalho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ex3Panel)
        Me.Name = "FrmTrabalho"
        Me.ex3Panel.ResumeLayout(False)
        Me.ex3Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ex3Panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lstNomes As ListBox
    Friend WithEvents txtNomes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProcurar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lstProcura As ListBox
    Friend WithEvents btnInserir As Button
    Friend WithEvents btnMaisVogais As Button
    Friend WithEvents lblMaisVogais As Label
    Friend WithEvents lstResult As ListBox
End Class
