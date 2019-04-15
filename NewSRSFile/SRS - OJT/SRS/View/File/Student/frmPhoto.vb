Imports System.Windows.Forms
Imports Emgu.CV
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum
Imports DirectShowLib

Public Class frmPhoto

    Dim _capture As Capture
    Private _CameraIndex As Integer = 0
  
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Try
            Dim image As Image(Of Bgr, Byte) = _capture.QueryFrame().ToImage(Of Bgr, Byte)()
            picStudent.BackgroundImage = image.ToBitmap
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmPhoto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _capture.Dispose()
        timer.Dispose()
    End Sub

    Private Sub BrowseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _capture = New Capture(0)
            _capture.FlipHorizontal = Not _capture.FlipHorizontal
            timer.Start()
            _capture.Start()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If btn2.Text = "TAKE PHOTO" Then
            _capture.Dispose()
            timer.Stop()
            btn2.Text = "RETAKE PHOTO"
            btn1.Text = "OK"
        Else
            btn2.Text = "TAKE PHOTO"
            btn1.Text = "CLOSE"
            _capture = New Capture()
            _capture.FlipHorizontal = Not _capture.FlipHorizontal
            timer.Start()
            _capture.Start()
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If btn1.Text = "OK" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        Me.Close()
    End Sub
End Class
