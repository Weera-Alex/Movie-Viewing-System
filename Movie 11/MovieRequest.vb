Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports MaterialSkin

Public Class MovieRequest

    Private ReadOnly cn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
C:\Users\john kan\Videos\Movie 11\Movie 11\Movie11.mdf;Integrated Security=True")

    Private cmd As SqlCommand
    Private adapt As SqlDataAdapter
    Private dt As DataTable
    Private requestID As Integer = 0
    Dim btn_edit As DataGridViewButtonColumn
    Dim btn_delete As DataGridViewButtonColumn
    Dim movieIDS As Integer

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As Integer

    End Function

    Public Sub New()
        InitializeComponent()

        'Display movie list when the form is opened
        MovieList()
        HomeOn()
        'hide tabcontrol
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        'textbox hint
        SendMessage(SearchtxtBox.Handle, &H1501, 0, "Titles, year, genres")
        'show year only format
        DGVrequestList.Columns(5).DefaultCellStyle.Format = "yyyy"
        DGVmovieList.Columns(3).DefaultCellStyle.Format = "yyyy"
        DGVmovieList.DefaultCellStyle.BackColor = Color.LightGray
        DGVrequestList.DefaultCellStyle.BackColor = Color.LightGray

        DGVmovieList.ColumnHeadersDefaultCellStyle.Font = New Font("roboto", 14, FontStyle.Regular)

    End Sub

    '▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    'Buttons in Request TabPage
    'Labels in Request TabPage

#Region "Request Tabpage"

    Private Sub TotalRq_Label_VisibleChanged(sender As Object, e As EventArgs) Handles TotalRq_Label.VisibleChanged
        cn.Open()
        cmd = New SqlCommand("select count (requestId) from Rqtable ", cn)
        Dim studentid As String = cmd.ExecuteScalar()
        TotalRq_Label.Text = studentid
        cn.Close()
    End Sub

    Private Sub St_label_VisibleChanged(sender As Object, e As EventArgs) Handles st_label.VisibleChanged
        cn.Open()
        cmd = New SqlCommand("select COUNT (DISTINCT studentId) from Rqtable ", cn)
        Dim studentid As String = cmd.ExecuteScalar()
        st_label.Text = studentid
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVrequestList.CellContentClick
        Try
            requestID = Convert.ToInt32(DGVrequestList.Rows(e.RowIndex).Cells(0).Value.ToString())
            rq_id.Text = DGVrequestList.Rows(e.RowIndex).Cells(0).Value.ToString()
            st_id.Text = DGVrequestList.Rows(e.RowIndex).Cells(1).Value.ToString()
            st_nm.Text = DGVrequestList.Rows(e.RowIndex).Cells(2).Value.ToString()
            title_mov.Text = DGVrequestList.Rows(e.RowIndex).Cells(3).Value.ToString()
            gen_mov.Text = DGVrequestList.Rows(e.RowIndex).Cells(4).Value.ToString()
            year_mov.Value = DGVrequestList.Rows(e.RowIndex).Cells(5).Value
        Catch
            'do nothing
        End Try
        Btn_request.Enabled = False

    End Sub

#End Region

    '▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    'fill datagridview
    'clear texbox

#Region "Method for displaying data and clearing textbox"

    Public Sub ViewData() 'display all asked list of current user
        cn.Open()
        Dim dt As New DataTable()
        adapt = New SqlDataAdapter("select * from ViewTable where studentId = @studentID", cn)
        adapt.SelectCommand.Parameters.Add("@studentId", SqlDbType.NVarChar).Value = newRq_st_id.Text
        adapt.Fill(dt)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Public Sub ViewDataAdmin() 'display all asked list
        cn.Open()
        Dim dt As New DataTable()
        adapt = New SqlDataAdapter("select * from ViewTable", cn)

        adapt.Fill(dt)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Public Sub DisplayDataAdmin() 'display all request list
        cn.Open()
        Dim dt As New DataTable()
        adapt = New SqlDataAdapter("select * from RqTable", cn)
        adapt.Fill(dt)
        DGVrequestList.DataSource = dt
        cn.Close()
    End Sub

    Public Sub DisplayData() 'display all request list of current user
        cn.Open()
        Dim dt As New DataTable()
        adapt = New SqlDataAdapter("select * from RqTable where studentId = @studentID", cn)
        adapt.SelectCommand.Parameters.Add("@studentId", SqlDbType.NVarChar).Value = st_id.Text
        adapt.Fill(dt)
        DGVrequestList.DataSource = dt
        cn.Close()
    End Sub

    Public Sub MovieList() 'display all movie list
        cn.Open()
        Dim dt As New DataTable()
        adapt = New SqlDataAdapter("select * from MvTable", cn)
        adapt.Fill(dt)
        DGVmovieList.DataSource = dt
        cn.Close()
    End Sub

    Private Sub ClearDataAdmin()
        rq_id.Text = ""
        st_id.Text = ""
        st_nm.Text = ""
        title_mov.Text = ""
        year_mov.Value = Date.Now
        gen_mov.Text = ""
        requestID = 0
    End Sub

    Private Sub ClearData()
        rq_id.Text = ""
        title_mov.Text = ""
        year_mov.Value = Date.Now
        gen_mov.Text = ""
        requestID = 0
    End Sub

#End Region

    '▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    'hide caret
    'for read only textbox

#Region "Hide Caret"

    Private Declare Function HideCaret Lib "user32.dll" (hWnd As IntPtr) As Boolean

    Private Sub Rq_id_GotFocus(sender As Object, e As EventArgs) Handles rq_id.GotFocus
        HideCaret(rq_id.Handle)
    End Sub

    Private Sub St_id_GotFocus(sender As Object, e As EventArgs) Handles st_id.GotFocus
        HideCaret(st_id.Handle)
    End Sub

    Private Sub NewRq_id_GotFocus(sender As Object, e As EventArgs) Handles newRq_id.GotFocus
        HideCaret(newRq_id.Handle)
    End Sub

    Private Sub NewRq_st_id_GotFocus(sender As Object, e As EventArgs) Handles newRq_st_id.GotFocus
        HideCaret(newRq_st_id.Handle)
    End Sub

    Private Sub St_nm_TextChanged(sender As Object, e As EventArgs) Handles st_nm.GotFocus
        HideCaret(st_nm.Handle)
    End Sub

#End Region

    '▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
    'search
    'add button
    'refresh button
    'create button to datagridview
    'edit and delete

#Region "MovieTabpage"

    Private Sub SearchtxtBox_LostFocus(sender As Object, e As EventArgs) Handles SearchtxtBox.LostFocus
        SearchActive.Visible = False
    End Sub

    Public Sub SearchtxtBox_GotFocus(sender As Object, e As EventArgs) Handles SearchtxtBox.GotFocus
        SearchActive.Visible = True
    End Sub

    Private Sub SearchActive_Click(sender As Object, e As EventArgs) Handles SearchActive.Click, SearchInactive.Click
        If SearchtxtBox.Text IsNot String.Empty Then
            cn.Open()
            adapt = New SqlDataAdapter("select * from MvTable where title_mov like '%" & SearchtxtBox.Text & "%'
            or year_mov Like '" & SearchtxtBox.Text & "%' Or gen_mov Like '%" & SearchtxtBox.Text & "%' Or MovieId Like '" & SearchtxtBox.Text & "%'", cn)

            dt = New DataTable()
            adapt.Fill(dt)
            DGVmovieList.DataSource = dt
            cn.Close()
        Else
            'do nothing
        End If
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        Dim f3 As New Insert(Me)
        If Application.OpenForms().OfType(Of Insert).Any Then
            'nothing
        Else
            f3.Show()
            f3.Button2.Enabled = False
        End If
    End Sub

    Public Sub Btn()
        'put edit button in datagridview
        btn_edit = New DataGridViewButtonColumn With {
            .Text = "Edit",
            .UseColumnTextForButtonValue = True,
            .Width = 80
        }
        DGVmovieList.Columns.Add(btn_edit)
        'delete button in datagridview
        btn_delete = New DataGridViewButtonColumn With {
            .Text = "Delete",
            .UseColumnTextForButtonValue = True,
            .Width = 80
        }
        DGVmovieList.Columns.Add(btn_delete)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVmovieList.CellContentClick
        Dim currentRow As Integer = Integer.Parse(e.RowIndex.ToString())
        Try
            Dim movieIDString As String = DGVmovieList(0, currentRow).Value.ToString()
            movieIDS = Integer.Parse(movieIDString)
        Catch ex As Exception
            ' do nothing
        End Try
        If DGVmovieList.Columns(e.ColumnIndex) Is btn_delete AndAlso currentRow >= 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this movie?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                cmd = New SqlCommand("DELETE FROM MvTable where MovieId=" & movieIDS & "", cn)
                cn.Open()
                cmd.Parameters.AddWithValue("@MovieId", movieIDS)
                cmd.ExecuteNonQuery()
                cn.Close()
                MovieList()
            End If
        ElseIf DGVmovieList.Columns(e.ColumnIndex) Is btn_edit AndAlso currentRow >= 0 Then
            If Application.OpenForms().OfType(Of Insert).Any Then
                'nothing
            Else
                Dim f2 As New Insert(Me) With {
                .id = DGVmovieList.Rows(e.RowIndex).Cells(0).Value.ToString(),
                .title = DGVmovieList.Rows(e.RowIndex).Cells(1).Value.ToString(),
                .genre = DGVmovieList.Rows(e.RowIndex).Cells(2).Value.ToString(),
                .year = DGVmovieList.Rows(e.RowIndex).Cells(3).Value(),
                .movieID = movieIDS
            }

                f2.Show()
                f2.Button1.Enabled = False
                f2.Edit()
                DGVmovieList.Update()
            End If
        End If
    End Sub

#End Region

#Region "Design"

    Private Sub MovieOff()
        MovieListLabel.Image = My.Resources.yea
        MovieListLabel.ForeColor = Color.Gray
        MovieListLabel.BackColor = Color.LightGray
    End Sub

    Private Sub MovieOn()
        MovieListLabel.Image = My.Resources.a
        MovieListLabel.ForeColor = Color.Black
        MovieListLabel.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub RequestOff()
        RequestLabel.Image = My.Resources.yeahy
        RequestLabel.ForeColor = Color.Gray
        RequestLabel.BackColor = Color.LightGray
    End Sub

    Private Sub RequestOn()
        RequestLabel.Image = My.Resources.b
        RequestLabel.ForeColor = Color.Black
        RequestLabel.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub WatchOff()
        WatchLabel.Image = My.Resources.yeah0
        WatchLabel.ForeColor = Color.Gray
        WatchLabel.BackColor = Color.LightGray
    End Sub

    Private Sub WatchOn()
        WatchLabel.Image = My.Resources.c
        WatchLabel.ForeColor = Color.Black
        WatchLabel.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub HomeOff()

        HomeLabel.ForeColor = Color.Gray
        HomeLabel.BackColor = Color.LightGray
    End Sub

    Private Sub HomeOn()

        HomeLabel.ForeColor = Color.Black
        HomeLabel.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub SettingOff()
        SettingLabel.ForeColor = Color.Gray
        Panel3.Visible = False
        SettingLabel.BackColor = Color.LightGray
    End Sub

    Private Sub SettingOn()
        SettingLabel.ForeColor = Color.Black
        Panel3.Visible = True
        SettingLabel.BackColor = Color.WhiteSmoke
    End Sub

#End Region

#Region "ColorsOffMethod"

    Private Sub RWSH()
        'MOVIE
        RequestOff()
        WatchOff()
        SettingOff()
        HomeOff()
    End Sub

    Private Sub MWSH()
        'REQUEST
        MovieOff()
        WatchOff()
        SettingOff()
        HomeOff()
    End Sub

    Private Sub MRSH()
        'WATCH
        MovieOff()
        RequestOff()
        SettingOff()
        HomeOff()
    End Sub

    Private Sub MRWH()
        'SETTING
        MovieOff()
        RequestOff()
        WatchOff()
        HomeOff()
    End Sub

    Private Sub MRWS()
        'HOME
        MovieOff()
        RequestOff()
        WatchOff()
        SettingOff()
    End Sub

#End Region

#Region "DesignCode"

    'under development

    'Private Sub Button1_MouseHover(sender As Object, e As EventArgs)
    '    Button1.ForeColor = Color.White
    'End Sub

    'Private Sub Button2_MouseHover(sender As Object, e As EventArgs)
    '    Btn_exit.ForeColor = Color.White
    'End Sub

    'Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
    '    Button1.ForeColor = Color.Silver
    'End Sub

    'Private Sub Button2_MouseLeave(sender As Object, e As EventArgs)
    '    Btn_exit.ForeColor = Color.Silver
    'End Sub

    Private Sub MovieListLabel_MouseHover(sender As Object, e As EventArgs) Handles MovieListLabel.MouseHover

        If RequestLabel.ForeColor = Color.Black OrElse WatchLabel.ForeColor = Color.Black OrElse HomeLabel.ForeColor = Color.Black Then
            MovieOn()
        Else
            MovieOff()
        End If
    End Sub

    Private Sub MovieListLabel_MouseLeave(sender As Object, e As EventArgs) Handles MovieListLabel.MouseLeave

        If RequestLabel.ForeColor = Color.Black OrElse WatchLabel.ForeColor = Color.Black OrElse HomeLabel.ForeColor = Color.Black Then
            MovieOff()
        Else
            MovieOn()
        End If
    End Sub

    Private Sub RequestLabel_MouseHover(sender As Object, e As EventArgs) Handles RequestLabel.MouseHover

        If MovieListLabel.ForeColor = Color.Black OrElse WatchLabel.ForeColor = Color.Black OrElse HomeLabel.ForeColor = Color.Black Then
            RequestOn()
        Else
            RequestOff()
        End If
    End Sub

    Private Sub RequestLabel_MouseLeave(sender As Object, e As EventArgs) Handles RequestLabel.MouseLeave

        If MovieListLabel.ForeColor = Color.Black OrElse WatchLabel.ForeColor = Color.Black OrElse HomeLabel.ForeColor = Color.Black Then
            RequestOff()
        Else
            RequestOn()
        End If
    End Sub

    Private Sub WatchLabel_MouseHover(sender As Object, e As EventArgs) Handles WatchLabel.MouseHover

        If MovieListLabel.ForeColor = Color.Black OrElse RequestLabel.ForeColor = Color.Black OrElse HomeLabel.ForeColor = Color.Black Then
            WatchOn()
        Else
            WatchOff()
        End If
    End Sub

    Private Sub WatchLabel_MouseLeave(sender As Object, e As EventArgs) Handles WatchLabel.MouseLeave

        If MovieListLabel.ForeColor = Color.Black OrElse RequestLabel.ForeColor = Color.Black OrElse HomeLabel.ForeColor = Color.Black Then
            WatchOff()
        Else
            WatchOn()
        End If
    End Sub

    Private Sub HomeLabel_MouseHover(sender As Object, e As EventArgs) Handles HomeLabel.MouseHover

        If MovieListLabel.ForeColor = Color.Black OrElse RequestLabel.ForeColor = Color.Black OrElse WatchLabel.ForeColor = Color.Black Then
            HomeOn()
        Else
            HomeOff()
        End If
    End Sub

    Private Sub HomeLabel_MouseLeave(sender As Object, e As EventArgs) Handles HomeLabel.MouseLeave

        If MovieListLabel.ForeColor = Color.Black OrElse RequestLabel.ForeColor = Color.Black OrElse WatchLabel.ForeColor = Color.Black Then
            HomeOff()
        Else
            HomeOn()
        End If
    End Sub

#End Region

#Region "Left Side Panel"

    Private Sub SettingLabel_Click(sender As Object, e As EventArgs) Handles SettingLabel.Click
        Select Case Panel3.Visible
            Case True

                SettingOff()
            Case Else
                SettingOn()

        End Select

    End Sub

    Private Sub WatchLabel_Click(sender As Object, e As EventArgs) Handles WatchLabel.Click
        Select Case Label8.Text = "admin"
            Case True
                ViewDataAdmin()
            Case Else
                ViewData()
        End Select
        WatchOn()
        RequestLabel.ForeColor = Color.Gray
        MovieListLabel.ForeColor = Color.Gray
        HomeLabel.ForeColor = Color.Gray
        TabControl1.SelectedIndex = 2
        If WatchLabel.ForeColor = Color.Black Then
            MRSH()

        End If
    End Sub

    Private Sub MovieListLabel_Click(sender As Object, e As EventArgs) Handles MovieListLabel.Click

        TabControl1.SelectedIndex = 0
        HomeLabel.ForeColor = Color.Gray
        RequestLabel.ForeColor = Color.Gray
        WatchLabel.ForeColor = Color.Gray
        MovieOn()
        If MovieListLabel.ForeColor = Color.Black Then

            RWSH()

        End If
    End Sub

    Private Sub RequestLabel_Click(sender As Object, e As EventArgs) Handles RequestLabel.Click
        Select Case Label8.Text = "admin"
            Case True
                Panel4.Visible = True
                Panel5.Visible = True
                DisplayDataAdmin()
            Case Else
                DisplayData()
        End Select
        TabControl1.SelectedIndex = 1
        RequestOn()
        MovieListLabel.ForeColor = Color.Gray
        WatchLabel.ForeColor = Color.Gray
        HomeLabel.ForeColor = Color.Gray

        If RequestLabel.ForeColor = Color.Black Then
            MWSH()

        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles HomeLabel.Click

        TabControl1.SelectedIndex = 3

        HomeOn()
        MovieListLabel.ForeColor = Color.Gray
        WatchLabel.ForeColor = Color.Gray
        RequestLabel.ForeColor = Color.Gray
        If HomeLabel.ForeColor = Color.Black Then
            MRWS()

        End If
    End Sub

#End Region

#Region "Watch TabPage"

    Private Sub DataGridView1_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            requestID = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
            newRq_id.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            newRq_st_id.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            newRq_mov.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        Catch
            'do nothing
        End Try
        Btn_ask.Enabled = False
    End Sub

    Private Sub MovieRequest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Application.OpenForms().OfType(Of Insert).Any Then
            Dim result As DialogResult = MessageBox.Show("You editing something want to close the application now?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                'nothing
            Else
                e.Cancel = True
            End If

        End If
    End Sub

    Public Shared lol As String

    Private Sub MovieRequest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Select Case Label8.Text = "admin"
            Case True
                'nothing
            Case Else

                cn.Open()
                cmd = New SqlCommand("insert into RecordTable values(@studentId,@timein,@timeout,@date_cre,@studentname)", cn)
                Dim timeout As DateTime

                timeout = DateTime.Now
                Dim now As DateTime = DateTime.Now
                cmd.Parameters.Add("@studentId", SqlDbType.NVarChar).Value = lol
                cmd.Parameters.Add("@timein", SqlDbType.VarChar).Value = Login.timein.ToString("HH:mm tt")
                cmd.Parameters.Add("@timeout", SqlDbType.VarChar).Value = timeout.ToString("HH:mm tt")
                cmd.Parameters.Add("@date_cre", SqlDbType.Date).Value = now.ToString("D")
                cmd.Parameters.Add("@studentname", SqlDbType.NVarChar).Value = st_nm.Text
                cmd.ExecuteNonQuery()
        End Select
        If Application.OpenForms().OfType(Of Insert).Any Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f1 As New Form2
        f1.ShowDialog()
    End Sub

    Private Sub MovieRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles Btn_refresh.Click
        MovieList()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click
        If requestID <> 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel this request?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                cmd = New SqlCommand("delete RqTable where RequestID=@requestId", cn)
                cn.Open()
                cmd.Parameters.Add("@requestId", SqlDbType.Int).Value = requestID
                cmd.ExecuteNonQuery()
                cn.Close()

                Select Case Label8.Text = "admin"
                    Case False
                        DisplayData()
                        ClearData()
                        Btn_request.Enabled = True
                    Case Else
                        DisplayDataAdmin()
                        ClearDataAdmin()
                End Select
            Else
                'nothing

            End If
        Else
            MessageBox.Show("Please select the one you sent to cancel it")
        End If
    End Sub

    Private Sub MaterialFlatButton1_Click_1(sender As Object, e As EventArgs) Handles Btn_clear.Click
        Select Case Label8.Text = "admin"

            Case False
                ClearData()
                Btn_request.Enabled = True
            Case Else
                ClearDataAdmin()
        End Select
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles Btn_update.Click
        If st_id.Text <> "" AndAlso st_nm.Text <> "" AndAlso title_mov.Text <> "" AndAlso year_mov.Text <>
        "" AndAlso gen_mov.Text <> "" AndAlso rq_id.Text <> "" Then

            cmd = New SqlCommand("update RqTable set RequestId=@requestId,StudentId=@studentId,StudentName=@studentName,
            Title_Mov=@title_mov,Year_Mov=@year_mov,Gen_mov=@gen_mov where requestID=@requestId", cn)
            cn.Open()
            cmd.Parameters.Add("@requestId", SqlDbType.Int).Value = rq_id.Text
            cmd.Parameters.Add("@studentId", SqlDbType.NVarChar).Value = st_id.Text
            cmd.Parameters.Add("@studentName", SqlDbType.NVarChar).Value = st_nm.Text.TrimStart
            cmd.Parameters.Add("@title_mov", SqlDbType.NVarChar).Value = title_mov.Text.TrimStart
            cmd.Parameters.Add("@year_mov", SqlDbType.Date).Value = year_mov.Value
            cmd.Parameters.Add("@gen_mov", SqlDbType.NVarChar).Value = gen_mov.Text.TrimStart
            cmd.ExecuteNonQuery()
            MessageBox.Show("your request has been updated")
            cn.Close()
            Select Case Label8.Text = "admin"
                Case False
                    DisplayData()
                    ClearData()
                    Btn_request.Enabled = True
                Case Else
                    DisplayDataAdmin()
                    ClearDataAdmin()
            End Select
        Else
            MessageBox.Show("Please select the one you sent to update it")
        End If
    End Sub

    Private Sub Btn_remove_Click(sender As Object, e As EventArgs) Handles Btn_remove.Click
        If requestID <> 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this request?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                cmd = New SqlCommand("delete ViewTable where id=@id", cn)
                cn.Open()
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = requestID
                cmd.ExecuteNonQuery()
                cn.Close()
                newRq_id.Text = ""
                newRq_mov.Text = ""
                requestID = 0
                ViewDataAdmin()
            Else
                'nothing
            End If
        Else
            MessageBox.Show("Please select something you want remove")
        End If
    End Sub

    Private Sub MaterialFlatButton2_Click_1(sender As Object, e As EventArgs) Handles Btn_clear_3rd.Click
        Select Case Label8.Text = "admin"
            Case False
                Btn_ask.Enabled = True
                newRq_id.Text = ""
                newRq_mov.Text = ""
                requestID = 0
            Case Else
                newRq_id.Text = ""
                newRq_mov.Text = ""
                newRq_st_id.Text = ""
                requestID = 0
        End Select
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim f1 As New Player
        Dim opnfd As New OpenFileDialog With {
            .Filter = "Video Files (*.mp4;*.mkv;.*.gif;)|*.mp4;*.mkv;.*.gif"
        }
        If opnfd.ShowDialog() = DialogResult.OK Then

            Dim highestValue = DataGridView1.Rows.OfType(Of DataGridViewRow).Max(Function(row) Convert.ToInt32(row.Cells(0).Value))
            For Each row As DataGridViewRow In DataGridView1.Rows

                Dim num As Integer = Val(row.Cells(0).Value)
                If num = highestValue Then
                    row.DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next
            Button2.Enabled = False
            f1.AxWindowsMediaPlayer1.URL = opnfd.FileName
            f1.ShowDialog()

        End If
    End Sub

    Private Sub MaterialRaisedButton1_Click_1(sender As Object, e As EventArgs) Handles Btn_request.Click
        If st_id.Text <> "" AndAlso st_nm.Text <> "" AndAlso title_mov.Text <> "" AndAlso year_mov.Text <> "" AndAlso gen_mov.Text <> "" Then
            Dim code As String
            Dim random As New Random()
            Dim value As Integer
            value = random.Next(0, 99999)
            st_nm.Text.ToUpper()
            If st_nm.Text.Count > 0 Then
                Dim remove As String = rq_id.Text.ToUpper.Replace(" ", "")
                remove = remove.Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "").Replace("1", "").
                    Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").
                    Replace("8", "").Replace("9", "").Replace("0", "")
                code = Format(Date.Now, "yyyy") & remove & value
                rq_id.Text = code
            End If
            cmd = New SqlCommand("insert into RqTable values(@requestId,@studentId,@studentName,@title_mov,@year_mov,@date_cre,@gen_mov)", cn)
            cn.Open()
            cmd.Parameters.Add("@requestId", SqlDbType.Int).Value = rq_id.Text
            cmd.Parameters.Add("@studentId", SqlDbType.NVarChar).Value = st_id.Text
            cmd.Parameters.Add("@studentName", SqlDbType.NVarChar).Value = st_nm.Text.TrimStart
            cmd.Parameters.Add("@title_mov", SqlDbType.NVarChar).Value = title_mov.Text.TrimStart
            cmd.Parameters.Add("@year_mov", SqlDbType.Date).Value = year_mov.Value
            cmd.Parameters.Add("@date_cre", SqlDbType.Date).Value = DateTimePicker1.Value.Date
            cmd.Parameters.Add("@gen_mov", SqlDbType.NVarChar).Value = gen_mov.Text.TrimStart
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("your suggestion has been sent")
            DisplayData()
            ClearData()
        Else
            MessageBox.Show("Please type what you need so we can add it for you", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub MaterialRaisedButton1_Click_2(sender As Object, e As EventArgs) Handles Btn_ask.Click
        If newRq_st_id.Text <> "" AndAlso newRq_mov.Text <> "" Then
            cmd = New SqlCommand("SELECT title_mov from MvTable where MovieId = @MovieId", cn)
            cn.Open()
            cmd.Parameters.Add("@MovieId", SqlDbType.Int).Value = newRq_mov.Text
            Dim text As String = cmd.ExecuteScalar()
            cn.Close()
            Select Case String.IsNullOrWhiteSpace(text)
                Case False
                    Dim result As DialogResult = MessageBox.Show("Is this what you want to watch?" & vbCrLf & text, "Confirmation", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        MessageBox.Show("Ask the librarian now, Enjoy Watching")

                        cmd = New SqlCommand("insert into ViewTable values(@studentId,@MovieId,@date_cre)", cn)
                        cn.Open()
                        cmd.Parameters.Add("@date_cre", SqlDbType.Date).Value = DateTimePicker2.Value.Date
                        cmd.Parameters.Add("@studentId", SqlDbType.NVarChar).Value = newRq_st_id.Text
                        cmd.Parameters.Add("@MovieId", SqlDbType.Int).Value = newRq_mov.Text
                        cmd.ExecuteNonQuery()
                        cn.Close()
                        Button2.Enabled = True
                        ViewData()
                        newRq_id.Text = ""
                        newRq_mov.Text = ""
                        Dim highestValue = DataGridView1.Rows.OfType(Of DataGridViewRow).Max(Function(row) Convert.ToInt32(row.Cells(0).Value))
                        For Each row As DataGridViewRow In DataGridView1.Rows

                            Dim num As Integer = Val(row.Cells(0).Value)
                            If num = highestValue Then
                                row.DefaultCellStyle.BackColor = Color.White
                            End If
                        Next
                    Else
                        'nothing
                    End If

                Case Else
                    MessageBox.Show("No movies that match the id you put")
            End Select
        Else
            MessageBox.Show("Please type the id of movie you want to watch", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

End Class