Imports System.Data.SqlClient

Public Class Insert

    Private ReadOnly cn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
C:\Users\john kan\Videos\Movie 11\Movie 11\Movie11.mdf;Integrated Security=True")

    Private cmd As SqlCommand
    Public title, genre As String
    Public year As Date
    Public movieID = 0, id As Integer
    Private ReadOnly passInstance As MovieRequest

    Public Sub New(getInstance As MovieRequest)
        InitializeComponent()
        passInstance = getInstance
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If title_mov1.Text <> "" AndAlso gen_mov1.Text <> "" AndAlso year_mov1.Text <> "" Then
            Dim code As String
            Dim random As New Random()
            Dim value As Integer
            value = random.Next(0, 99999)
            title_mov1.Text.ToUpper()
            If title_mov1.Text.Count > 0 Then
                Dim remove As String = TextBox1.Text.ToUpper.Replace(" ", "")
                remove = remove.Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "").Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("0", "")
                code = Format(Date.Now, "yyyy") & remove & value
                TextBox1.Text = code
            End If
            cmd = New SqlCommand("insert into MvTable values(@MovieId,@title_mov,@year_mov,@gen_mov)", cn)
            cn.Open()
            cmd.Parameters.Add("@MovieId", SqlDbType.Int).Value = TextBox1.Text
            cmd.Parameters.Add("@title_mov", SqlDbType.NVarChar).Value = title_mov1.Text.TrimStart
            cmd.Parameters.Add("@year_mov", SqlDbType.Date).Value = year_mov1.Value
            cmd.Parameters.Add("@gen_mov", SqlDbType.NVarChar).Value = gen_mov1.Text.TrimStart
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Movie is added to the list")
            passInstance.MovieList()
            ClearData()
        Else
            MessageBox.Show("Please fill all the field")
        End If
    End Sub

    Private Sub ClearData()
        TextBox1.Text = ""
        title_mov1.Text = ""
        year_mov1.Value = Date.Now
        gen_mov1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If title_mov1.Text <> "" AndAlso year_mov1.Text <> "" AndAlso gen_mov1.Text <> "" Then
            cmd = New SqlCommand("update MvTable set MovieId=@MovieId ,Title_Mov=@title_mov,Gen_mov=@gen_mov,Year_Mov=@year_mov where movieID=@MovieId", cn)
            cn.Open()
            cmd.Parameters.Add("@MovieId", SqlDbType.Int).Value = TextBox1.Text
            cmd.Parameters.Add("@title_mov", SqlDbType.NVarChar).Value = title_mov1.Text.TrimStart
            cmd.Parameters.Add("@year_mov", SqlDbType.Date).Value = year_mov1.Value
            cmd.Parameters.Add("@gen_mov", SqlDbType.NVarChar).Value = gen_mov1.Text.TrimStart
            cmd.ExecuteNonQuery()
            MessageBox.Show("edited succesfully")
            passInstance.MovieList()
            cn.Close()
            Close()
        Else
            MessageBox.Show("Please fill all field")
        End If
    End Sub

    Public Sub Edit()
        title_mov1.Text = title
        year_mov1.Value = year
        gen_mov1.Text = genre
        TextBox1.Text = id
    End Sub

    Private Declare Function HideCaret Lib "user32.dll" (hWnd As IntPtr) As Boolean

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        HideCaret(TextBox1.Handle)
    End Sub

End Class