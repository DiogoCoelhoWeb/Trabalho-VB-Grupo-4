Public Class Form1
    Private Sub intrBtn_Click(sender As Object, e As EventArgs) Handles intrBtn.Click
        lstB.Items.Clear()
        Input()
        Dim txt As String = ""
        While txt <> "FIM"
            txt = InputBox("Introduza os nomes até introduzir 'FIM'", "Introduzir") &
            lstB.Items.Add(txt)
            If txt = "" Then
                txt = "FIM"
            End If


        End While
    End Sub
End Class
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
