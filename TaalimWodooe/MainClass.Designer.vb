<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainClass
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(356, 592)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ابدأ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MainClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TaalimWodooe.My.Resources.Resources.back22
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(873, 696)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Name = "MainClass"
        Me.Text = "تعلم الوضوء"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
