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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Send = New System.Windows.Forms.Button()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(72, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(258, 20)
        Me.TextBox2.TabIndex = 0
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(264, 95)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(75, 23)
        Me.Send.TabIndex = 3
        Me.Send.Text = "Envoyer"
        Me.Send.UseVisualStyleBackColor = True
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(16, 95)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(75, 23)
        Me.Fermer.TabIndex = 4
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = True
        '
        'PartEntreprise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 130)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "PartEntreprise"
        Me.Text = "PartEntreprise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Send As Button
    Friend WithEvents Fermer As Button
End Class
