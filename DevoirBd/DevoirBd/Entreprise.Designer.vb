<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entreprise
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NomEntreprise = New System.Windows.Forms.TextBox()
        Me.PrixPart = New System.Windows.Forms.MaskedTextBox()
        Me.NbrPartTotal = New System.Windows.Forms.MaskedTextBox()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.Send = New System.Windows.Forms.Button()
        Me.IdEntreprise = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom de l'entreprise"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prix Part :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de part Total"
        '
        'NomEntreprise
        '
        Me.NomEntreprise.Location = New System.Drawing.Point(131, 36)
        Me.NomEntreprise.MaxLength = 500
        Me.NomEntreprise.Name = "NomEntreprise"
        Me.NomEntreprise.Size = New System.Drawing.Size(202, 20)
        Me.NomEntreprise.TabIndex = 3
        '
        'PrixPart
        '
        Me.PrixPart.Location = New System.Drawing.Point(131, 63)
        Me.PrixPart.Mask = "9999999999,99"
        Me.PrixPart.Name = "PrixPart"
        Me.PrixPart.Size = New System.Drawing.Size(82, 20)
        Me.PrixPart.TabIndex = 4
        Me.PrixPart.ValidatingType = GetType(Integer)
        '
        'NbrPartTotal
        '
        Me.NbrPartTotal.Location = New System.Drawing.Point(131, 89)
        Me.NbrPartTotal.Mask = "99999"
        Me.NbrPartTotal.Name = "NbrPartTotal"
        Me.NbrPartTotal.Size = New System.Drawing.Size(82, 20)
        Me.NbrPartTotal.TabIndex = 5
        Me.NbrPartTotal.ValidatingType = GetType(Integer)
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(12, 130)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(75, 23)
        Me.Fermer.TabIndex = 6
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = True
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(255, 130)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(75, 23)
        Me.Send.TabIndex = 7
        Me.Send.Text = "Envoyer"
        Me.Send.UseVisualStyleBackColor = True
        '
        'IdEntreprise
        '
        Me.IdEntreprise.Location = New System.Drawing.Point(131, 12)
        Me.IdEntreprise.Mask = "99999"
        Me.IdEntreprise.Name = "IdEntreprise"
        Me.IdEntreprise.Size = New System.Drawing.Size(82, 20)
        Me.IdEntreprise.TabIndex = 5
        Me.IdEntreprise.ValidatingType = GetType(Integer)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "id Entreprise"
        '
        'Entreprise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 165)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.IdEntreprise)
        Me.Controls.Add(Me.NbrPartTotal)
        Me.Controls.Add(Me.PrixPart)
        Me.Controls.Add(Me.NomEntreprise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Entreprise"
        Me.Text = "Entreprise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NomEntreprise As TextBox
    Friend WithEvents PrixPart As MaskedTextBox
    Friend WithEvents NbrPartTotal As MaskedTextBox
    Friend WithEvents Fermer As Button
    Friend WithEvents Send As Button
    Friend WithEvents IdEntreprise As MaskedTextBox
    Friend WithEvents Label4 As Label
End Class
