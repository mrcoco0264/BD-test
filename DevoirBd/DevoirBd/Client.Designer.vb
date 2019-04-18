<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Client
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Prenom = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.Send = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IdClient = New System.Windows.Forms.MaskedTextBox()
        Me.IdEmployer = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Prenom
        '
        Me.Prenom.Location = New System.Drawing.Point(107, 42)
        Me.Prenom.MaxLength = 200
        Me.Prenom.Name = "Prenom"
        Me.Prenom.Size = New System.Drawing.Size(192, 20)
        Me.Prenom.TabIndex = 0
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(107, 64)
        Me.nom.MaxLength = 200
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(192, 20)
        Me.nom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Prénom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nom :"
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(12, 119)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(75, 23)
        Me.Fermer.TabIndex = 7
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = True
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(224, 116)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(75, 23)
        Me.Send.TabIndex = 8
        Me.Send.Text = "Envoyer"
        Me.Send.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id Employer :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Id Client:"
        '
        'IdClient
        '
        Me.IdClient.Location = New System.Drawing.Point(107, 20)
        Me.IdClient.Mask = "99999"
        Me.IdClient.Name = "IdClient"
        Me.IdClient.Size = New System.Drawing.Size(100, 20)
        Me.IdClient.TabIndex = 9
        Me.IdClient.ValidatingType = GetType(Integer)
        '
        'IdEmployer
        '
        Me.IdEmployer.Location = New System.Drawing.Point(107, 87)
        Me.IdEmployer.Mask = "99999"
        Me.IdEmployer.Name = "IdEmployer"
        Me.IdEmployer.Size = New System.Drawing.Size(100, 20)
        Me.IdEmployer.TabIndex = 9
        Me.IdEmployer.ValidatingType = GetType(Integer)
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 154)
        Me.Controls.Add(Me.IdEmployer)
        Me.Controls.Add(Me.IdClient)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Prenom)
        Me.Name = "Client"
        Me.Text = "Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Prenom As TextBox
    Friend WithEvents nom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Fermer As Button
    Friend WithEvents Send As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IdClient As MaskedTextBox
    Friend WithEvents IdEmployer As MaskedTextBox
End Class
