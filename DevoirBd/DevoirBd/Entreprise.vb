Imports Oracle.ManagedDataAccess.Client
Public Class Entreprise
    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        Me.Close()
    End Sub

    Private Sub Entreprise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Querry As String = "Insert into Entreprise values(" + idEntreprise.Text + ")"

        Form1.cmd = New OracleCommand(Querry)
        Try
            Form1.conn.open()
            Form1.cmd.ExecuteNonQuery()
            Form1.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Try
                If (Form1.conn.state = ConnectionState.Open) Then
                    Form1.conn.close()
                End If
            Catch ex2 As Exception
                MsgBox(ex2.Message)
            End Try
        End Try
    End Sub
End Class