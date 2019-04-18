<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employer
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
        Me.Prenom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.Envoyer = New System.Windows.Forms.Button()
        Me.idEmployer = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Prenom
        '
        Me.Prenom.Location = New System.Drawing.Point(93, 40)
        Me.Prenom.MaxLength = 200
        Me.Prenom.Name = "Prenom"
        Me.Prenom.Size = New System.Drawing.Size(167, 20)
        Me.Prenom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Prenom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom:"
        '
        'Nom
        '
        Me.Nom.Location = New System.Drawing.Point(93, 68)
        Me.Nom.MaxLength = 200
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(167, 20)
        Me.Nom.TabIndex = 3
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(19, 92)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(75, 23)
        Me.Fermer.TabIndex = 4
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = True
        '
        'Envoyer
        '
        Me.Envoyer.Location = New System.Drawing.Point(191, 94)
        Me.Envoyer.Name = "Envoyer"
        Me.Envoyer.Size = New System.Drawing.Size(75, 23)
        Me.Envoyer.TabIndex = 5
        Me.Envoyer.Text = "Envoyer"
        Me.Envoyer.UseVisualStyleBackColor = True
        '
        'idEmployer
        '
        Me.idEmployer.Location = New System.Drawing.Point(93, 14)
        Me.idEmployer.Mask = "99999"
        Me.idEmployer.Name = "idEmployer"
        Me.idEmployer.Size = New System.Drawing.Size(167, 20)
        Me.idEmployer.TabIndex = 6
        Me.idEmployer.ValidatingType = GetType(Integer)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Id Employer :"
        '
        'Employer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 136)
        Me.Controls.Add(Me.idEmployer)
        Me.Controls.Add(Me.Envoyer)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Prenom)
        Me.Name = "Employer"
        Me.Text = "Employer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Prenom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Nom As TextBox
    Friend WithEvents Fermer As Button
    Friend WithEvents Envoyer As Button
    Friend WithEvents idEmployer As MaskedTextBox
    Friend WithEvents Label3 As Label
End Class
