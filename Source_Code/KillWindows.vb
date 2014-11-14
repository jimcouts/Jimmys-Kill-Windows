Option Explicit On
Public Class frmShutdown

    Private Sub cmdRestart_Click(sender As Object, e As EventArgs) Handles cmdRestart.Click
        System.Diagnostics.Process.Start("shutdown", "-r -t 00")
    End Sub

    Private Sub cmdShutDown_Click(sender As Object, e As EventArgs) Handles cmdShutDown.Click
        System.Diagnostics.Process.Start("shutdown", "-s -t 20")
    End Sub

    Private Sub cmdLogOff_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("shutdown", "-l -t 00")
    End Sub

    Private Sub cmdForceShutdown_Click(sender As Object, e As EventArgs) Handles cmdForceShutdown.Click
        System.Diagnostics.Process.Start("shutdown", "-s -f -t 00")
    End Sub
End Class
