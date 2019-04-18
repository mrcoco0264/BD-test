<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rechercher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Entreprise = New System.Windows.Forms.RadioButton()
        Me.Employer = New System.Windows.Forms.RadioButton()
        Me.Client = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.NomTXT = New System.Windows.Forms.TextBox()
        Me.PrenomTXT = New System.Windows.Forms.TextBox()
        Me.Prenom = New System.Windows.Forms.RadioButton()
        Me.Nom = New System.Windows.Forms.RadioButton()
        Me.GrilleDeRecherche = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrilleDeRecherche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Entreprise)
        Me.GroupBox1.Controls.Add(Me.Employer)
        Me.GroupBox1.Controls.Add(Me.Client)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 99)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher"
        '
        'Entreprise
        '
        Me.Entreprise.AutoSize = True
        Me.Entreprise.Location = New System.Drawing.Point(7, 66)
        Me.Entreprise.Name = "Entreprise"
        Me.Entreprise.Size = New System.Drawing.Size(72, 17)
        Me.Entreprise.TabIndex = 2
        Me.Entreprise.TabStop = True
        Me.Entreprise.Text = "Entreprise"
        Me.Entreprise.UseVisualStyleBackColor = True
        '
        'Employer
        '
        Me.Employer.AutoSize = True
        Me.Employer.Location = New System.Drawing.Point(7, 43)
        Me.Employer.Name = "Employer"
        Me.Employer.Size = New System.Drawing.Size(68, 17)
        Me.Employer.TabIndex = 1
        Me.Employer.TabStop = True
        Me.Employer.Text = "Employer"
        Me.Employer.UseVisualStyleBackColor = True
        '
        'Client
        '
        Me.Client.AutoSize = True
        Me.Client.Location = New System.Drawing.Point(7, 20)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(51, 17)
        Me.Client.TabIndex = 0
        Me.Client.TabStop = True
        Me.Client.Text = "Client"
        Me.Client.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Search)
        Me.GroupBox2.Controls.Add(Me.Fermer)
        Me.GroupBox2.Controls.Add(Me.NomTXT)
        Me.GroupBox2.Controls.Add(Me.PrenomTXT)
        Me.GroupBox2.Controls.Add(Me.Prenom)
        Me.GroupBox2.Controls.Add(Me.Nom)
        Me.GroupBox2.Location = New System.Drawing.Point(124, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 99)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type de Recherche"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(275, 70)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 23)
        Me.Search.TabIndex = 3
        Me.Search.Text = "Recherche"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(7, 70)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(75, 23)
        Me.Fermer.TabIndex = 3
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = True
        '
        'NomTXT
        '
        Me.NomTXT.Location = New System.Drawing.Point(73, 40)
        Me.NomTXT.MaxLength = 500
        Me.NomTXT.Name = "NomTXT"
        Me.NomTXT.Size = New System.Drawing.Size(219, 20)
        Me.NomTXT.TabIndex = 2
        '
        'PrenomTXT
        '
        Me.PrenomTXT.Location = New System.Drawing.Point(73, 19)
        Me.PrenomTXT.MaxLength = 200
        Me.PrenomTXT.Name = "PrenomTXT"
        Me.PrenomTXT.Size = New System.Drawing.Size(219, 20)
        Me.PrenomTXT.TabIndex = 2
        '
        'Prenom
        '
        Me.Prenom.AutoSize = True
        Me.Prenom.Location = New System.Drawing.Point(6, 20)
        Me.Prenom.Name = "Prenom"
        Me.Prenom.Size = New System.Drawing.Size(61, 17)
        Me.Prenom.TabIndex = 0
        Me.Prenom.TabStop = True
        Me.Prenom.Text = "Prénom"
        Me.Prenom.UseVisualStyleBackColor = True
        '
        'Nom
        '
        Me.Nom.AutoSize = True
        Me.Nom.Location = New System.Drawing.Point(6, 43)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(53, 17)
        Me.Nom.TabIndex = 1
        Me.Nom.TabStop = True
        Me.Nom.Text = "Nom :"
        Me.Nom.UseVisualStyleBackColor = True
        '
        'GrilleDeRecherche
        '
        Me.GrilleDeRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrilleDeRecherche.Location = New System.Drawing.Point(12, 119)
        Me.GrilleDeRecherche.Name = "GrilleDeRecherche"
        Me.GrilleDeRecherche.Size = New System.Drawing.Size(468, 319)
        Me.GrilleDeRecherche.TabIndex = 2
        '
        'Rechercher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 450)
        Me.Controls.Add(Me.GrilleDeRecherche)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Rechercher"
        Me.Text = "Rechercher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GrilleDeRecherche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Entreprise As RadioButton
    Friend WithEvents Employer As RadioButton
    Friend WithEvents Client As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NomTXT As TextBox
    Friend WithEvents PrenomTXT As TextBox
    Friend WithEvents Prenom As RadioButton
    Friend WithEvents Nom As RadioButton
    Friend WithEvents Search As Button
    Friend WithEvents Fermer As Button
    Friend WithEvents GrilleDeRecherche As DataGridView
End Class
