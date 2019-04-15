Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            Try
                If IsConnected() = True Then
                    frmHome.mainTimer.Start()
                Else
                    Dim err As New frmError
                    err.lblMsg.Text = "Server unreachable. Check your network connection."
                    err.ShowDialog()
                End If
            Catch ex As Exception
                Dim err As New frmError
                err.lblMsg.Text = "Server unreachable. Check your network connection."
                err.ShowDialog()
            End Try
        End Sub

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Enrollment System is already running."
            warn.ShowDialog()
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Try

            Catch ex As Exception
                Dim err As New frmError
                err.lblMsg.Text = "FAILED 404."
                err.ShowDialog()
            End Try
        End Sub
    End Class


End Namespace

