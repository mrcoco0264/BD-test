<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartEntreprise
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
        Me.Send = New System.Windows.Forms.Button()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IdClient = New System.Windows.Forms.MaskedTextBox()
        Me.idEntreprise = New System.Windows.Forms.MaskedTextBox()
        Me.NbrPart = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "idClient"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "idEntreprise"
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(109, 90)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(75, 23)
        Me.Send.TabIndex = 3
        Me.Send.Text = "Envoyer"
        Me.Send.UseVisualStyleBackColor = True
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(12, 90)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(75, 23)
        Me.Fermer.TabIndex = 4
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NbrPart"
        '
        'IdClient
        '
        Me.IdClient.Location = New System.Drawing.Point(84, 13)
        Me.IdClient.Mask = "99999"
        Me.IdClient.Name = "IdClient"
        Me.IdClient.Size = New System.Drawing.Size(100, 20)
        Me.IdClient.TabIndex = 5
        Me.IdClient.ValidatingType = GetType(Integer)
        '
        'idEntreprise
        '
        Me.idEntreprise.Location = New System.Drawing.Point(83, 38)
        Me.idEntreprise.Mask = "99999"
        Me.idEntreprise.Name = "idEntreprise"
        Me.idEntreprise.Size = New System.Drawing.Size(100, 20)
        Me.idEntreprise.TabIndex = 5
        Me.idEntreprise.ValidatingType = GetType(Integer)
        '
        'NbrPart
        '
        Me.NbrPart.Location = New System.Drawing.Point(83, 64)
        Me.NbrPart.Mask = "99999"
        Me.NbrPart.Name = "NbrPart"
        Me.NbrPart.Size = New System.Drawing.Size(100, 20)
        Me.NbrPart.TabIndex = 5
        Me.NbrPart.ValidatingType = GetType(Integer)
        '
        'PartEntreprise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 122)
        Me.Controls.Add(Me.NbrPart)
        Me.Controls.Add(Me.idEntreprise)
        Me.Controls.Add(Me.IdClient)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PartEntreprise"
        Me.Text = "PartEntreprise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Send As Button
    Friend WithEvents Fermer As Button

    Friend WithEvents Label4 As Label
    Friend WithEvents IdClient As MaskedTextBox
    Friend WithEvents idEntreprise As MaskedTextBox
    Friend WithEvents NbrPart As MaskedTextBox

    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox

End Class
