<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.playBtn = New System.Windows.Forms.Button()
        Me.sifatBtn = New System.Windows.Forms.Button()
        Me.fadlBtn = New System.Windows.Forms.Button()
        Me.hokmBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playBtn
        '
        Me.playBtn.BackColor = System.Drawing.Color.Gold
        Me.playBtn.Font = New System.Drawing.Font("Hacen Sahafa", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.playBtn.ForeColor = System.Drawing.Color.White
        Me.playBtn.Location = New System.Drawing.Point(55, 151)
        Me.playBtn.Name = "playBtn"
        Me.playBtn.Size = New System.Drawing.Size(184, 56)
        Me.playBtn.TabIndex = 8
        Me.playBtn.Text = "هيا للعب"
        Me.playBtn.UseVisualStyleBackColor = False
        '
        'sifatBtn
        '
        Me.sifatBtn.BackColor = System.Drawing.Color.MediumAquamarine
        Me.sifatBtn.Font = New System.Drawing.Font("Hacen Sahafa", 15.0!)
        Me.sifatBtn.ForeColor = System.Drawing.Color.White
        Me.sifatBtn.Location = New System.Drawing.Point(55, 60)
        Me.sifatBtn.Name = "sifatBtn"
        Me.sifatBtn.Size = New System.Drawing.Size(184, 56)
        Me.sifatBtn.TabIndex = 7
        Me.sifatBtn.Text = "صفة الوضوء"
        Me.sifatBtn.UseVisualStyleBackColor = False
        '
        'fadlBtn
        '
        Me.fadlBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fadlBtn.BackColor = System.Drawing.Color.Coral
        Me.fadlBtn.Font = New System.Drawing.Font("Hacen Sahafa", 15.0!)
        Me.fadlBtn.ForeColor = System.Drawing.Color.White
        Me.fadlBtn.Location = New System.Drawing.Point(674, 60)
        Me.fadlBtn.Name = "fadlBtn"
        Me.fadlBtn.Size = New System.Drawing.Size(184, 56)
        Me.fadlBtn.TabIndex = 7
        Me.fadlBtn.Text = " فضل الوضوء"
        Me.fadlBtn.UseVisualStyleBackColor = False
        '
        'hokmBtn
        '
        Me.hokmBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hokmBtn.BackColor = System.Drawing.Color.DarkViolet
        Me.hokmBtn.Font = New System.Drawing.Font("Hacen Sahafa", 15.0!)
        Me.hokmBtn.ForeColor = System.Drawing.Color.White
        Me.hokmBtn.Location = New System.Drawing.Point(674, 151)
        Me.hokmBtn.Name = "hokmBtn"
        Me.hokmBtn.Size = New System.Drawing.Size(184, 56)
        Me.hokmBtn.TabIndex = 8
        Me.hokmBtn.Text = "حكم الوضوء"
        Me.hokmBtn.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Hacen Sahafa", 12.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.TextBox1.Location = New System.Drawing.Point(418, 297)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 48)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.TaalimWodooe.My.Resources.Resources.home
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button1.Font = New System.Drawing.Font("Hacen Sahafa", 15.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(284, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 50)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ابحث"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TaalimWodooe.My.Resources.Resources.back23
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 582)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.hokmBtn)
        Me.Controls.Add(Me.fadlBtn)
        Me.Controls.Add(Me.playBtn)
        Me.Controls.Add(Me.sifatBtn)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "تعلم الوضوء"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents playBtn As Windows.Forms.Button
    Friend WithEvents sifatBtn As Windows.Forms.Button
    Friend WithEvents fadlBtn As Windows.Forms.Button
    Friend WithEvents hokmBtn As Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
