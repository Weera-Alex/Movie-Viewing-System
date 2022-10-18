Imports AxWMPLib

Public Class Player

    Private Sub AxWindowsMediaPlayer1_MediaError(sender As Object,
    ByVal e As _WMPOCXEvents_MediaErrorEvent) Handles AxWindowsMediaPlayer1.MediaError
        Try
            ' If the file is corrupt or missing, show the
            ' hexadecimal error code and URL.
            Dim errSource As WMPLib.IWMPMedia2 = e.pMediaObject
            Dim errorItem As WMPLib.IWMPErrorItem = errSource.Error
            MessageBox.Show("Media error " & errorItem.errorCode.ToString("X") _
                            & " in " & errSource.sourceURL)
        Catch ex As InvalidCastException
            ' In case pMediaObject is not an IWMPMedia item.
            MessageBox.Show("Player error.")
        End Try
    End Sub

    Private Sub Player_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.close()

    End Sub

    Private Sub Player_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

End Class