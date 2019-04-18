Friend Class OracleConnection
    Friend ConnectionString As String
    Private orabd As String

    Public Sub New(orabd As String)
        Me.orabd = orabd
    End Sub
End Class
