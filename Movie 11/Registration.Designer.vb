<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registration
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.btnRegister1 = New System.Windows.Forms.Button()
        Me.Show = New System.Windows.Forms.CheckBox()
        Me.txtstudentId = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtconfirmpassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgen = New System.Windows.Forms.ComboBox()
        Me.txtstudentnm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegister1
        '
        Me.btnRegister1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnRegister1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister1.Font = New System.Drawing.Font("Leelawadee UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister1.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRegister1.Location = New System.Drawing.Point(884, 410)
        Me.btnRegister1.Name = "btnRegister1"
        Me.btnRegister1.Size = New System.Drawing.Size(260, 50)
        Me.btnRegister1.TabIndex = 78
        Me.btnRegister1.Text = "CREATE ACCOUNT"
        Me.btnRegister1.UseVisualStyleBackColor = False
        '
        'Show
        '
        Me.Show.AutoSize = True
        Me.Show.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Show.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Show.Location = New System.Drawing.Point(597, 410)
        Me.Show.Name = "Show"
        Me.Show.Size = New System.Drawing.Size(141, 21)
        Me.Show.TabIndex = 80
        Me.Show.TabStop = False
        Me.Show.Text = "Show Password"
        Me.Show.UseVisualStyleBackColor = False
        '
        'txtstudentId
        '
        Me.txtstudentId.BackColor = System.Drawing.Color.LightGray
        Me.txtstudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstudentId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentId.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtstudentId.Location = New System.Drawing.Point(597, 172)
        Me.txtstudentId.MaxLength = 11
        Me.txtstudentId.Name = "txtstudentId"
        Me.txtstudentId.Size = New System.Drawing.Size(258, 34)
        Me.txtstudentId.TabIndex = 1
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.label6.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label6.Location = New System.Drawing.Point(595, 135)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(105, 20)
        Me.label6.TabIndex = 85
        Me.label6.Text = "Student ID"
        '
        'linkLabel1
        '
        Me.linkLabel1.ActiveLinkColor = System.Drawing.Color.MediumAquamarine
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.linkLabel1.Font = New System.Drawing.Font("Leelawadee UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLabel1.LinkColor = System.Drawing.Color.Orange
        Me.linkLabel1.Location = New System.Drawing.Point(1089, 473)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(55, 20)
        Me.linkLabel1.TabIndex = 79
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "Sign-In"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.label4.Font = New System.Drawing.Font("Leelawadee UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.label4.Location = New System.Drawing.Point(882, 473)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(177, 20)
        Me.label4.TabIndex = 84
        Me.label4.Text = "Already have an account?"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.LightGray
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpassword.Location = New System.Drawing.Point(599, 357)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(259, 34)
        Me.txtpassword.TabIndex = 5
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.LightGray
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtusername.Location = New System.Drawing.Point(600, 268)
        Me.txtusername.MaxLength = 30
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(258, 34)
        Me.txtusername.TabIndex = 4
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label2.Location = New System.Drawing.Point(595, 323)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(132, 20)
        Me.label2.TabIndex = 82
        Me.label2.Text = "New Password"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label1.Location = New System.Drawing.Point(595, 234)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(138, 20)
        Me.label1.TabIndex = 81
        Me.label1.Text = "New Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtconfirmpassword)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtgen)
        Me.Panel1.Controls.Add(Me.txtstudentnm)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnRegister1)
        Me.Panel1.Controls.Add(Me.Show)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.txtstudentId)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Me.linkLabel1)
        Me.Panel1.Controls.Add(Me.label4)
        Me.Panel1.Controls.Add(Me.label6)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1222, 755)
        Me.Panel1.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(882, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 20)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Confirm Password"
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.BackColor = System.Drawing.Color.LightGray
        Me.txtconfirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtconfirmpassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtconfirmpassword.Location = New System.Drawing.Point(886, 357)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.Size = New System.Drawing.Size(259, 34)
        Me.txtconfirmpassword.TabIndex = 93
        Me.txtconfirmpassword.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(579, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 37)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Registration"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(882, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Gender"
        '
        'txtgen
        '
        Me.txtgen.BackColor = System.Drawing.Color.LightGray
        Me.txtgen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtgen.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgen.FormattingEnabled = True
        Me.txtgen.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.txtgen.Location = New System.Drawing.Point(886, 268)
        Me.txtgen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtgen.Name = "txtgen"
        Me.txtgen.Size = New System.Drawing.Size(261, 33)
        Me.txtgen.TabIndex = 0
        Me.txtgen.TabStop = False
        '
        'txtstudentnm
        '
        Me.txtstudentnm.BackColor = System.Drawing.Color.LightGray
        Me.txtstudentnm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstudentnm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudentnm.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtstudentnm.Location = New System.Drawing.Point(886, 172)
        Me.txtstudentnm.MaxLength = 26
        Me.txtstudentnm.Name = "txtstudentnm"
        Me.txtstudentnm.Size = New System.Drawing.Size(258, 34)
        Me.txtstudentnm.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(884, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Student Name"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackgroundImage = Global.Movie_11.My.Resources.Resources.Screenshot_2021_04_11_192910_digital_art_x4
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(-7, -35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(515, 809)
        Me.Panel2.TabIndex = 87
        '
        'Registration
        '
        Me.AcceptButton = Me.btnRegister1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.linkLabel1
        Me.ClientSize = New System.Drawing.Size(1222, 774)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Movie"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnRegister1 As Button
    Private WithEvents Show As CheckBox
    Private WithEvents txtstudentId As TextBox
    Private WithEvents label6 As Label
    Private WithEvents linkLabel1 As LinkLabel
    Private WithEvents label4 As Label
    Private WithEvents txtpassword As TextBox
    Private WithEvents txtusername As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Private WithEvents Label5 As Label
    Friend WithEvents txtgen As ComboBox
    Private WithEvents txtstudentnm As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Private WithEvents Label8 As Label
    Private WithEvents txtconfirmpassword As TextBox
End Class
