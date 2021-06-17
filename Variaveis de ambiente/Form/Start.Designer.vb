<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.lbVar = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbVar
        '
        Me.lbVar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbVar.FormattingEnabled = True
        Me.lbVar.Location = New System.Drawing.Point(0, 0)
        Me.lbVar.Name = "lbVar"
        Me.lbVar.Size = New System.Drawing.Size(725, 284)
        Me.lbVar.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 284)
        Me.Controls.Add(Me.lbVar)
        Me.Name = "Form1"
        Me.Text = "Variavies de ambiente"
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lbVar As System.Windows.Forms.ListBox

End Class
