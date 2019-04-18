<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Fermeture = New System.Windows.Forms.Button()
        Me.PartEntreprise = New System.Windows.Forms.Button()
        Me.CreerClient = New System.Windows.Forms.Button()
        Me.CreerEmployer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Recherche = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Fermeture
        '
        Me.Fermeture.Location = New System.Drawing.Point(238, 102)
        Me.Fermeture.Name = "Fermeture"
        Me.Fermeture.Size = New System.Drawing.Size(75, 23)
        Me.Fermeture.TabIndex = 0
        Me.Fermeture.Text = "Fermerture"
        Me.Fermeture.UseVisualStyleBackColor = True
        '
        'PartEntreprise
        '
        Me.PartEntreprise.Location = New System.Drawing.Point(121, 13)
        Me.PartEntreprise.Name = "PartEntreprise"
        Me.PartEntreprise.Size = New System.Drawing.Size(192, 53)
        Me.PartEntreprise.TabIndex = 4
        Me.PartEntreprise.Text = "Acheter Part d'entreprise"
        Me.PartEntreprise.UseVisualStyleBackColor = True
        '
        'CreerClient
        '
        Me.CreerClient.Location = New System.Drawing.Point(12, 13)
        Me.CreerClient.Name = "CreerClient"
        Me.CreerClient.Size = New System.Drawing.Size(103, 23)
        Me.CreerClient.TabIndex = 5
        Me.CreerClient.Text = "Créer Client"
        Me.CreerClient.UseVisualStyleBackColor = True
        '
        'CreerEmployer
        '
        Me.CreerEmployer.Location = New System.Drawing.Point(13, 43)
        Me.CreerEmployer.Name = "CreerEmployer"
        Me.CreerEmployer.Size = New System.Drawing.Size(102, 23)
        Me.CreerEmployer.TabIndex = 6
        Me.CreerEmployer.Text = "Créer Employer"
        Me.CreerEmployer.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Créer Entreprise"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Recherche
        '
        Me.Recherche.Location = New System.Drawing.Point(122, 73)
        Me.Recherche.Name = "Recherche"
        Me.Recherche.Size = New System.Drawing.Size(188, 23)
        Me.Recherche.TabIndex = 8
        Me.Recherche.Text = "Rechercher"
        Me.Recherche.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 129)
        Me.Controls.Add(Me.Recherche)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CreerEmployer)
        Me.Controls.Add(Me.CreerClient)
        Me.Controls.Add(Me.PartEntreprise)
        Me.Controls.Add(Me.Fermeture)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Fermeture As Button
    Friend WithEvents PartEntreprise As Button
    Friend WithEvents CreerClient As Button
    Friend WithEvents CreerEmployer As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Recherche As Button
End Class
