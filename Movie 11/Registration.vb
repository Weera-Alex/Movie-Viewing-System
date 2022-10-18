Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class Registration
    Inherits MaterialForm

    Private cmd As SqlCommand
    Private cn As SqlConnection
    Private dr As SqlDataReader

    Public Sub New()

        InitializeComponent()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        Owner.Show()
        Hide()
    End Sub

    Private Sub Show_CheckedChanged(sender As Object, e As EventArgs) Handles Show.CheckedChanged
        txtpassword.UseSystemPasswordChar = Not Show.Checked
        txtconfirmpassword.UseSystemPasswordChar = Not Show.Checked
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
C:\Users\john kan\Videos\Movie 11\Movie 11\Movie11.mdf;Integrated Security=True")
        cn.Open()
        btnRegister1.FlatAppearance.BorderColor = Color.Orange
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub BtnRegister1_Click(sender As Object, e As EventArgs) Handles btnRegister1.Click
        If txtpassword.Text <> String.Empty AndAlso txtusername.Text <>
        String.Empty AndAlso txtstudentId.Text <> String.Empty AndAlso txtstudentnm.Text <> String.Empty AndAlso txtgen.Text <> String.Empty AndAlso txtconfirmpassword.Text <> String.Empty Then
            If txtpassword.Text = txtconfirmpassword.Text Then
                cmd = New SqlCommand("select * from LoginTable where username =@username  or studentId=@studentId", cn)
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtusername.Text
                cmd.Parameters.Add("@studentId", SqlDbType.NVarChar).Value = txtstudentId.Text
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    dr.Close()
                    MessageBox.Show("Username or StudentId already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    dr.Close()
                    cmd = New SqlCommand("insert into LoginTable values(@username,@password,@studentId,@studentname,@gender)", cn)
                    cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = txtgen.Text
                    cmd.Parameters.Add("@studentname", SqlDbType.NVarChar).Value = txtstudentnm.Text
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtusername.Text
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtpassword.Text
                    cmd.Parameters.Add("@studentId", SqlDbType.NVarChar).Value = txtstudentId.Text
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtstudentId.Text = ""
                    txtpassword.Text = ""
                    txtconfirmpassword.Text = ""
                    txtusername.Text = ""
                    txtstudentnm.Text = ""
                    txtgen.SelectedIndex = -1
                End If
            Else
                txtconfirmpassword.Text = ""
                MessageBox.Show("Password must match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter value in all field", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub TxtstudentId_TextChanged(sender As Object, e As EventArgs) Handles txtstudentId.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtstudentId.Text = digitsOnly.Replace(txtstudentId.Text, "")
    End Sub

End Class