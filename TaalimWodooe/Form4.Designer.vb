<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fadlBtn = New System.Windows.Forms.Button()
        Me.sifatBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label1.Font = New System.Drawing.Font("Hacen Sahafa", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(259, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 52)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = " "" بالطهارة يـ   x  & "" "" & ""تنال محبة الله عز وجل """
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TaalimWodooe.My.Resources.Resources.home
        Me.PictureBox1.Location = New System.Drawing.Point(24, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'fadlBtn
        '
        Me.fadlBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fadlBtn.BackColor = System.Drawing.Color.Coral
        Me.fadlBtn.Font = New System.Drawing.Font("Hacen Sahafa", 15.0!)
        Me.fadlBtn.ForeColor = System.Drawing.Color.White
        Me.fadlBtn.Location = New System.Drawing.Point(644, 206)
        Me.fadlBtn.Name = "fadlBtn"
        Me.fadlBtn.Size = New System.Drawing.Size(215, 56)
        Me.fadlBtn.TabIndex = 10
        Me.fadlBtn.Text = "متى يجب الوضوء"
        Me.fadlBtn.UseVisualStyleBackColor = False
        '
        'sifatBtn
        '
        Me.sifatBtn.BackColor = System.Drawing.Color.MediumAquamarine
        Me.sifatBtn.Font = New System.Drawing.Font("Hacen Sahafa", 15.0!)
        Me.sifatBtn.ForeColor = System.Drawing.Color.White
        Me.sifatBtn.Location = New System.Drawing.Point(35, 206)
        Me.sifatBtn.Name = "sifatBtn"
        Me.sifatBtn.Size = New System.Drawing.Size(247, 56)
        Me.sifatBtn.TabIndex = 11
        Me.sifatBtn.Text = "متى يكون الوضوء سنة"
        Me.sifatBtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.TaalimWodooe.My.Resources.Resources.back
        Me.PictureBox2.Location = New System.Drawing.Point(12, 532)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Hacen Sahafa", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(64, 535)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 35)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "العودة"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TaalimWodooe.My.Resources.Resources.back_child
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 582)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.fadlBtn)
        Me.Controls.Add(Me.sifatBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True

        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents fadlBtn As Windows.Forms.Button
    Friend WithEvents sifatBtn As Windows.Forms.Button
    Friend WithEvents PictureBox2 As Windows.Forms.PictureBox
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
