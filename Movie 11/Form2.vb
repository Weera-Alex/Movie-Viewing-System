Imports System.Data.SqlClient

Public Class Form2

    Private ReadOnly cn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
C:\Users\john kan\Videos\Movie 11\Movie 11\Movie11.mdf;Integrated Security=True")

    Private dr As SqlDataReader
    Private cmd As SqlCommand
    Private adapt As SqlDataAdapter
    Private dt As DataTable

    Public Sub New()
        InitializeComponent()

        Recordtable()
        User()

    End Sub

    Public Sub User()
        cn.Open()
        Dim dt As New DataTable()
        adapt = New SqlDataAdapter("select * from LoginTable", cn)
        adapt.Fill(dt)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Public Sub Recordtable()
        cn.Open()
        Dim dt As New DataTable()
        adapt = New SqlDataAdapter("select * from RecordTable", cn)

        adapt.Fill(dt)
        DataGridView2.DataSource = dt
        cn.Close()
    End Sub

    Private Sub SearchtxtBox_LostFocus(sender As Object, e As EventArgs) Handles SearchtxtBox.LostFocus
        SearchActive.Visible = False
    End Sub

    Public Sub SearchtxtBox_GotFocus(sender As Object, e As EventArgs) Handles SearchtxtBox.GotFocus
        SearchActive.Visible = True
    End Sub

    Private Sub SearchActive_Click(sender As Object, e As EventArgs) Handles SearchActive.Click, SearchInactive.Click
        If SearchtxtBox.Text IsNot String.Empty Then
            cn.Open()
            adapt = New SqlDataAdapter("select * from LoginTable where studentname like '%" & SearchtxtBox.Text & "%'
            or gender Like '" & SearchtxtBox.Text & "%' Or studentId Like '" & SearchtxtBox.Text & "%'", cn)
            dt = New DataTable()
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        Else
            'do nothing
        End If
    End Sub

    Private Sub Show_CheckedChanged(sender As Object, e As EventArgs) Handles Show.CheckedChanged
        txtpass.UseSystemPasswordChar = Not Show.Checked
        txtnw.UseSystemPasswordChar = Not Show.Checked
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Movie11DataSet8.RecordTable' table. You can move, or remove it, as needed.
        Me.RecordTableTableAdapter2.Fill(Me.Movie11DataSet8.RecordTable)
        cmd = New SqlCommand("select * from LoginTable", cn)

        Dim table As New DataTable()

        adapt.Fill(table)

        ComboBox1.DataSource = table

        ComboBox1.DisplayMember = "studentname"
        ComboBox1.ValueMember = "studentId"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cn.Open()
        Dim dt As New DataTable()
        adapt = New SqlDataAdapter("select * from RecordTable where studentname = @studentname", cn)
        adapt.SelectCommand.Parameters.Add("@studentname", SqlDbType.NVarChar).Value = ComboBox1.Text
        adapt.Fill(dt)
        DataGridView2.DataSource = dt
        cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Recordtable()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtuser.Text <> "" AndAlso txtpass.Text <> "" AndAlso txtnw.Text <> "" Then
            cn.Open()
            cmd = New SqlCommand("select * from LoginTable where username=@username and password=@password", cn)
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtuser.Text
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtpass.Text
            dr = cmd.ExecuteReader()

            If Not dr.Read() Then
                cn.Close()
                dr.Close()
                MessageBox.Show("We cannot find an account with that username or your password is incorrect ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dr.Close()
                cmd = New SqlCommand("update LoginTable set password=@password where username=@username", cn)
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtuser.Text
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtnw.Text

                cmd.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("Your password is updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtnw.Text = ""
                txtpass.Text = ""
                txtnw.Text = ""
            End If
        Else
            MessageBox.Show("Please put your account info to be able change your password", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        User()
    End Sub

End Class