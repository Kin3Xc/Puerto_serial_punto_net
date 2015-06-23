Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscapuertos()
    End Sub

    Private Sub buscapuertos()
        Try
            cmbPort.Items.Clear()
            For Each puertos As String In My.Computer.Ports.SerialPortNames
                cmbPort.Items.Add(puertos)
            Next

            If cmbPort.Items.Count > 0 Then
                cmbPort.SelectedIndex = 0
            Else
                MsgBox("NO HAY PUERTOS DISPONIBLES EN TU SISTEMA", MsgBoxStyle.Critical, "OBTENIENDO PUERTOS")
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnconectar_Click(sender As Object, e As EventArgs) Handles btnconectar.Click
        Try
            With sppuerto

            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
