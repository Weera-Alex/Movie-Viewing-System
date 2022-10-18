<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.SearchActive = New System.Windows.Forms.Label()
        Me.SearchInactive = New System.Windows.Forms.Label()
        Me.SearchtxtBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie11DataSet5 = New Movie_11.Movie11DataSet5()
        Me.LoginTableTableAdapter = New Movie_11.Movie11DataSet5TableAdapters.LoginTableTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Show = New System.Windows.Forms.CheckBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtnw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeoutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatecreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie11DataSet8 = New Movie_11.Movie11DataSet8()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RecordTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie11DataSet7 = New Movie_11.Movie11DataSet7()
        Me.RecordTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie11DataSet6 = New Movie_11.Movie11DataSet6()
        Me.RecordTableTableAdapter = New Movie_11.Movie11DataSet6TableAdapters.RecordTableTableAdapter()
        Me.RecordTableTableAdapter1 = New Movie_11.Movie11DataSet7TableAdapters.RecordTableTableAdapter()
        Me.RecordTableTableAdapter2 = New Movie_11.Movie11DataSet8TableAdapters.RecordTableTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie11DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie11DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.RecordTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie11DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie11DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchActive
        '
        Me.SearchActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchActive.ForeColor = System.Drawing.Color.Black
        Me.SearchActive.Image = Global.Movie_11.My.Resources.Resources.image
        Me.SearchActive.Location = New System.Drawing.Point(400, 58)
        Me.SearchActive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SearchActive.Name = "SearchActive"
        Me.SearchActive.Size = New System.Drawing.Size(47, 35)
        Me.SearchActive.TabIndex = 26
        Me.SearchActive.Visible = False
        '
        'SearchInactive
        '
        Me.SearchInactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInactive.ForeColor = System.Drawing.Color.Black
        Me.SearchInactive.Image = Global.Movie_11.My.Resources.Resources.rsz_1rsz_screenshot_2021_03_30_151933
        Me.SearchInactive.Location = New System.Drawing.Point(400, 58)
        Me.SearchInactive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SearchInactive.Name = "SearchInactive"
        Me.SearchInactive.Size = New System.Drawing.Size(47, 36)
        Me.SearchInactive.TabIndex = 23
        '
        'SearchtxtBox
        '
        Me.SearchtxtBox.BackColor = System.Drawing.Color.Gainsboro
        Me.SearchtxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchtxtBox.Font = New System.Drawing.Font("Roboto", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchtxtBox.Location = New System.Drawing.Point(42, 58)
        Me.SearchtxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchtxtBox.MaxLength = 25
        Me.SearchtxtBox.Name = "SearchtxtBox"
        Me.SearchtxtBox.Size = New System.Drawing.Size(405, 35)
        Me.SearchtxtBox.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIdDataGridViewTextBoxColumn, Me.StudentnameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LoginTableBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(42, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(697, 347)
        Me.DataGridView1.TabIndex = 27
        '
        'StudentIdDataGridViewTextBoxColumn
        '
        Me.StudentIdDataGridViewTextBoxColumn.DataPropertyName = "studentId"
        Me.StudentIdDataGridViewTextBoxColumn.HeaderText = "studentId"
        Me.StudentIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentIdDataGridViewTextBoxColumn.Name = "StudentIdDataGridViewTextBoxColumn"
        Me.StudentIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentIdDataGridViewTextBoxColumn.Width = 125
        '
        'StudentnameDataGridViewTextBoxColumn
        '
        Me.StudentnameDataGridViewTextBoxColumn.DataPropertyName = "studentname"
        Me.StudentnameDataGridViewTextBoxColumn.HeaderText = "studentname"
        Me.StudentnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StudentnameDataGridViewTextBoxColumn.Name = "StudentnameDataGridViewTextBoxColumn"
        Me.StudentnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentnameDataGridViewTextBoxColumn.Width = 190
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'LoginTableBindingSource
        '
        Me.LoginTableBindingSource.DataMember = "LoginTable"
        Me.LoginTableBindingSource.DataSource = Me.Movie11DataSet5
        '
        'Movie11DataSet5
        '
        Me.Movie11DataSet5.DataSetName = "Movie11DataSet5"
        Me.Movie11DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginTableTableAdapter
        '
        Me.LoginTableTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "PASSWORD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "USERNAME:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 17)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "NEW PASSWORD:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1252, 701)
        Me.TabControl1.TabIndex = 77
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1244, 672)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "USER"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.SearchActive)
        Me.Panel4.Controls.Add(Me.SearchInactive)
        Me.Panel4.Controls.Add(Me.SearchtxtBox)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Location = New System.Drawing.Point(436, 99)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(777, 523)
        Me.Panel4.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 20)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Users Information:"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(495, 59)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 34)
        Me.Button4.TabIndex = 87
        Me.Button4.Text = "REFRESH"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Show)
        Me.Panel1.Controls.Add(Me.txtuser)
        Me.Panel1.Controls.Add(Me.txtpass)
        Me.Panel1.Controls.Add(Me.txtnw)
        Me.Panel1.Location = New System.Drawing.Point(8, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 523)
        Me.Panel1.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 20)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Changed password:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(20, 312)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(260, 37)
        Me.Button3.TabIndex = 86
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Show
        '
        Me.Show.AutoSize = True
        Me.Show.BackColor = System.Drawing.Color.Transparent
        Me.Show.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show.ForeColor = System.Drawing.Color.Black
        Me.Show.Location = New System.Drawing.Point(21, 266)
        Me.Show.Name = "Show"
        Me.Show.Size = New System.Drawing.Size(141, 21)
        Me.Show.TabIndex = 81
        Me.Show.TabStop = False
        Me.Show.Text = "Show Password"
        Me.Show.UseVisualStyleBackColor = False
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.Gainsboro
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtuser.Location = New System.Drawing.Point(21, 99)
        Me.txtuser.MaxLength = 30
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(259, 34)
        Me.txtuser.TabIndex = 84
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.Gainsboro
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtpass.Location = New System.Drawing.Point(21, 159)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(259, 34)
        Me.txtpass.TabIndex = 82
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtnw
        '
        Me.txtnw.BackColor = System.Drawing.Color.Gainsboro
        Me.txtnw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnw.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnw.Location = New System.Drawing.Point(21, 216)
        Me.txtnw.Name = "txtnw"
        Me.txtnw.Size = New System.Drawing.Size(259, 34)
        Me.txtnw.TabIndex = 83
        Me.txtnw.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-4, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1252, 44)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "STUDENT MAINTENANCE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1244, 672)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "RECORD"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.StudentIdDataGridViewTextBoxColumn1, Me.StudentnameDataGridViewTextBoxColumn1, Me.TimeinDataGridViewTextBoxColumn, Me.TimeoutDataGridViewTextBoxColumn, Me.DatecreDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.RecordTableBindingSource2
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Location = New System.Drawing.Point(44, 131)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1153, 462)
        Me.DataGridView2.TabIndex = 6
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'StudentIdDataGridViewTextBoxColumn1
        '
        Me.StudentIdDataGridViewTextBoxColumn1.DataPropertyName = "studentId"
        Me.StudentIdDataGridViewTextBoxColumn1.HeaderText = "studentId"
        Me.StudentIdDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.StudentIdDataGridViewTextBoxColumn1.Name = "StudentIdDataGridViewTextBoxColumn1"
        Me.StudentIdDataGridViewTextBoxColumn1.Width = 125
        '
        'StudentnameDataGridViewTextBoxColumn1
        '
        Me.StudentnameDataGridViewTextBoxColumn1.DataPropertyName = "studentname"
        Me.StudentnameDataGridViewTextBoxColumn1.HeaderText = "studentname"
        Me.StudentnameDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.StudentnameDataGridViewTextBoxColumn1.Name = "StudentnameDataGridViewTextBoxColumn1"
        Me.StudentnameDataGridViewTextBoxColumn1.Width = 125
        '
        'TimeinDataGridViewTextBoxColumn
        '
        Me.TimeinDataGridViewTextBoxColumn.DataPropertyName = "timein"
        Me.TimeinDataGridViewTextBoxColumn.HeaderText = "timein"
        Me.TimeinDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TimeinDataGridViewTextBoxColumn.Name = "TimeinDataGridViewTextBoxColumn"
        Me.TimeinDataGridViewTextBoxColumn.Width = 125
        '
        'TimeoutDataGridViewTextBoxColumn
        '
        Me.TimeoutDataGridViewTextBoxColumn.DataPropertyName = "timeout"
        Me.TimeoutDataGridViewTextBoxColumn.HeaderText = "timeout"
        Me.TimeoutDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TimeoutDataGridViewTextBoxColumn.Name = "TimeoutDataGridViewTextBoxColumn"
        Me.TimeoutDataGridViewTextBoxColumn.Width = 125
        '
        'DatecreDataGridViewTextBoxColumn
        '
        Me.DatecreDataGridViewTextBoxColumn.DataPropertyName = "date_cre"
        Me.DatecreDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DatecreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DatecreDataGridViewTextBoxColumn.Name = "DatecreDataGridViewTextBoxColumn"
        Me.DatecreDataGridViewTextBoxColumn.Width = 125
        '
        'RecordTableBindingSource2
        '
        Me.RecordTableBindingSource2.DataMember = "RecordTable"
        Me.RecordTableBindingSource2.DataSource = Me.Movie11DataSet8
        '
        'Movie11DataSet8
        '
        Me.Movie11DataSet8.DataSetName = "Movie11DataSet8"
        Me.Movie11DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(44, 65)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1196, 46)
        Me.Panel2.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(705, 4)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "ALL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(584, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "FILTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownHeight = 180
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Location = New System.Drawing.Point(108, 5)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(467, 32)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 46)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Select User:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1238, 44)
        Me.Panel3.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(-7, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1245, 44)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "STUDENT MONITORING"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RecordTableBindingSource1
        '
        Me.RecordTableBindingSource1.DataMember = "RecordTable"
        Me.RecordTableBindingSource1.DataSource = Me.Movie11DataSet7
        '
        'Movie11DataSet7
        '
        Me.Movie11DataSet7.DataSetName = "Movie11DataSet7"
        Me.Movie11DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecordTableBindingSource
        '
        Me.RecordTableBindingSource.DataMember = "RecordTable"
        Me.RecordTableBindingSource.DataSource = Me.Movie11DataSet6
        '
        'Movie11DataSet6
        '
        Me.Movie11DataSet6.DataSetName = "Movie11DataSet6"
        Me.Movie11DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecordTableTableAdapter
        '
        Me.RecordTableTableAdapter.ClearBeforeFill = True
        '
        'RecordTableTableAdapter1
        '
        Me.RecordTableTableAdapter1.ClearBeforeFill = True
        '
        'RecordTableTableAdapter2
        '
        Me.RecordTableTableAdapter2.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 701)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Library Movie"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie11DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie11DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.RecordTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie11DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie11DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents SearchActive As Label
    Private WithEvents SearchInactive As Label
    Public WithEvents SearchtxtBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Movie11DataSet5 As Movie11DataSet5
    Friend WithEvents LoginTableBindingSource As BindingSource
    Friend WithEvents LoginTableTableAdapter As Movie11DataSet5TableAdapters.LoginTableTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents Show As CheckBox
    Private WithEvents txtnw As TextBox
    Private WithEvents txtpass As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Movie11DataSet6 As Movie11DataSet6
    Friend WithEvents RecordTableBindingSource As BindingSource
    Friend WithEvents RecordTableTableAdapter As Movie11DataSet6TableAdapters.RecordTableTableAdapter
    Friend WithEvents Movie11DataSet7 As Movie11DataSet7
    Friend WithEvents RecordTableBindingSource1 As BindingSource
    Friend WithEvents RecordTableTableAdapter1 As Movie11DataSet7TableAdapters.RecordTableTableAdapter
    Private WithEvents txtuser As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Movie11DataSet8 As Movie11DataSet8
    Friend WithEvents RecordTableBindingSource2 As BindingSource
    Friend WithEvents RecordTableTableAdapter2 As Movie11DataSet8TableAdapters.RecordTableTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents StudentIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StudentnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TimeinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatecreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
