Imports System.Data.SqlClient
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class Login
    Inherits MaterialForm

    Private cmd As SqlCommand
    Private cn As SqlConnection
    Private dr As SqlDataReader
    Private BtnLogin_Click2 As Integer = 0
    Dim timer As Integer
    Public Shared timein As DateTime

    Private _registration As Registration

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Frm2_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)

        _registration = Nothing 'If form is closed make sure reference is set to null

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If _registration Is Nothing Then
            _registration = New Registration() 'Create form if not created
            AddHandler _registration.FormClosed, AddressOf Frm2_FormClosed 'Add eventhandler to cleanup after form closes
        End If

        _registration.Show(Me) 'Show Form assigning this form as the forms owner
        Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
C:\Users\john kan\Videos\Movie 11\Movie 11\Movie11.mdf;Integrated Security=True")
        cn.Open()
        btnLogin.FlatAppearance.BorderColor = Color.Orange
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtpassword.Text <> String.Empty AndAlso txtusername.Text <> String.Empty Then
            cmd = New SqlCommand("select * from LoginTable where Username= @username and Password= @password", cn)
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtusername.Text
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtpassword.Text
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                If StrComp(txtpassword.Text, dr.GetValue(1), 0) = 0 AndAlso Not txtusername.Text.ToLower = "admin" Then
                    dr.Close()

                    timein = DateTime.Now

                    User()
                ElseIf txtusername.Text = "admin" Then
                    Admin()
                Else
                    BtnLogin_Click2 += 1
                    dr.Close()
                    MessageBox.Show("We cannot find an account with that username or your password is incorrect ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                BtnLogin_Click2 += 1
                dr.Close()
                MessageBox.Show("We cannot find an account with that username or your password is incorrect ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter value in all field", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub BtnLogin2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If BtnLogin_Click2 >= 5 Then
            btnLogin.Enabled = False
            LinkLabel1.Enabled = False
            Label_error.Visible = True
            Timer1.Enabled = True
            Timer1.Start()
            Timer1.Interval = 1000
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer += 1
        If timer >= 60 Then
            Timer1.Stop()
            btnLogin.Enabled = True
            LinkLabel1.Enabled = True
            Label_error.Visible = False
            timer = 0
            BtnLogin_Click2 = 0
        End If
    End Sub

    Private Sub Show_CheckedChanged(sender As Object, e As EventArgs) Handles Show.CheckedChanged
        txtpassword.UseSystemPasswordChar = Not Show.Checked
    End Sub

    Private Sub Admin()
        Hide()
        Dim Movie As New MovieRequest()
        Movie.DisplayDataAdmin()
        Movie.Btn()
        Movie.Btn_remove.Visible = True
        Movie.Btn_request.Enabled = False
        Movie.Btn_ask.Enabled = False
        Movie.Label8.Text = "admin"
        Movie.TabControl1.SelectedIndex = 3
        Movie.ShowDialog()
        Close()
    End Sub

    Private Sub User()
        Hide()
        dr.Close()
        cmd = New SqlCommand("select studentname from LoginTable where username = @username", cn)
        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtusername.Text
        Dim studentName As String = cmd.ExecuteScalar()

        studentName = studentName.ToLower()
        Dim capitalized As String = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(studentName)

        Dim Movie As New MovieRequest()
        cmd = New SqlCommand("select studentId from LoginTable where username = @username", cn)
        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtusername.Text
        Dim studentid As String = cmd.ExecuteScalar()
        cn.Close()
        Movie.DisplayData()
        Movie.st_id.Text = studentid
        Movie.newRq_st_id.Text = studentid
        Movie.Btn_add.Visible = False
        Movie.lol = studentid
        Movie.Label8.Text = capitalized
        Movie.st_nm.Text = capitalized
        Movie.Button3.Visible = False
        Movie.Btn_remove.Visible = False
        Movie.Button2.Enabled = False
        Movie.TabControl1.SelectedIndex = 3
        Movie.ShowDialog()
        Close()
    End Sub

End Class