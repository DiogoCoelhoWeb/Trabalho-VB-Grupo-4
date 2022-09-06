Public Class FrmTrabalho

    Public Shared nomes(0) As String

    Private Sub SairToolStripMenuItem_Click_1(sender As Object, e As EventArgs) 
        Application.Exit()
    End Sub

    Private Sub FrmTrabalho_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstNomes.Items.Clear()
        lstProcura.Items.Clear()
        lstResult.Items.Clear()
    End Sub

    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click

        Dim procura As String
        Dim x As Integer

        procura = txtNomes.Text

        lstProcura.Items.Clear()

        For x = 0 To nomes.Length() - 2
            If nomes(x).Contains(procura) Then
                lstProcura.Items.Add(nomes(x))
            End If
        Next
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Dim numNomes, x As Integer
        Dim nome As String

        numNomes = Val(InputBox("Quantos nomes gostaria de inserir?"))

        For x = 1 To numNomes
            nome = InputBox("Insira o " & x & "º nome:")

            lstNomes.Items.Add(nome)

            ReDim Preserve nomes(nomes.Length())
            nomes(nomes.Length() - 2) = nome
        Next

    End Sub

    Private Sub btnMaisVogais_Click(sender As Object, e As EventArgs) Handles btnMaisVogais.Click

        Dim nome As String
        Dim x, y, nVogais, maiorNumVogais As Integer

        maiorNumVogais = 0

        nome = lstNomes.SelectedItem

        If lstResult.Visible = True Then
            lstResult.Visible = False
            lblMaisVogais.Visible = False
            btnMaisVogais.Text = "Palavra com Mais Vogais"
        Else
            If nome <> "" Then
                lstResult.Items.Clear()

                Dim palavras() As String = nome.Split(" ")

                Dim numVogaisVet(palavras.Length()) As Integer

                For x = 0 To palavras.Length() - 1

                    nVogais = 0

                    For y = 1 To palavras(x).Length()
                        If InStr("aeiou", Mid(palavras(x), y, 1)) Then
                            nVogais = nVogais + 1
                        End If
                    Next

                    numVogaisVet(x) = nVogais

                    If nVogais > maiorNumVogais Then
                        maiorNumVogais = nVogais
                    End If

                Next

                If maiorNumVogais <> 0 Then
                    For x = 0 To numVogaisVet.Length() - 1
                        If numVogaisVet(x) = maiorNumVogais Then
                            lstResult.Items.Add(palavras(x))
                        End If
                    Next
                Else
                    lstResult.Items.Add("O nome não contem vogais")
                End If


                lstResult.Visible = True
                lblMaisVogais.Visible = True
                btnMaisVogais.Text = "Remover Resultado"
            Else
                MessageBox.Show("Por favor selecione um nome!", "Selecionar Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If


    End Sub
End Class
