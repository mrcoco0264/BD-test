Imports System.Data
Imports Oracle.ManagedDataAccess.Client ' ODP.NET, Managed Driver 
Imports Oracle.ManagedDataAccess.Types

'Imports class1.vb'
Public Class Form1
    Private f2 As New Client
    Private f3 As New Entreprise
    Private f4 As New Employer
    Private f5 As New Rechercher
    Private f6 As New PartEntreprise
    Public cmd
    Public conn

    Private Sub Fermeture_Click(sender As Object, e As EventArgs) Handles Fermeture.Click
        Me.Close()
        Console.WriteLine("OwO")
        conn.dispose()
        End
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StrConnection As String = "Data Source=SMI1002_16/76wbwa63@//132.209.11.3:1521/coursbd;"
        Console.WriteLine("OwO")
        conn = New Oracle.ManagedDataAccess.Client.OracleConnection(StrConnection)
    End Sub

    Private Sub CreerClient_Click(sender As Object, e As EventArgs) Handles CreerClient.Click
        f2.ShowDialog(Me)
    End Sub

    Private Sub CreerEmployer_Click(sender As Object, e As EventArgs) Handles CreerEmployer.Click
        f4.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f3.ShowDialog(Me)
    End Sub

    Private Sub Recherche_Click(sender As Object, e As EventArgs) Handles Recherche.Click
        f5.ShowDialog(Me)
    End Sub

    Private Sub PartEntreprise_Click(sender As Object, e As EventArgs) Handles PartEntreprise.Click
        f6.ShowDialog(Me)
    End Sub
End Class
