Public Class Rechercher
    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        Me.Close()
    End Sub

    Private Sub Rechercher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrenomTXT.Enabled = False
        NomTXT.Enabled = False
    End Sub

    Private Sub Prenom_CheckedChanged(sender As Object, e As EventArgs) Handles Prenom.CheckedChanged
        PrenomTXT.Enabled = True
        NomTXT.Enabled = False
        NomTXT.Text = ""
        Entreprise.Enabled = False

    End Sub

    Private Sub Nom_CheckedChanged(sender As Object, e As EventArgs) Handles Nom.CheckedChanged
        PrenomTXT.Enabled = False
        NomTXT.Enabled = True
        PrenomTXT.Text = ""
        Entreprise.Enabled = True
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
    End Sub

    Private Sub Entreprise_CheckedChanged(sender As Object, e As EventArgs) Handles Entreprise.CheckedChanged
        Prenom.Enabled = False

    End Sub

    Private Sub Employer_CheckedChanged(sender As Object, e As EventArgs) Handles Employer.CheckedChanged
        Prenom.Enabled = True
    End Sub

    Private Sub Client_CheckedChanged(sender As Object, e As EventArgs) Handles Client.CheckedChanged
        Prenom.Enabled = True
    End Sub
End Class