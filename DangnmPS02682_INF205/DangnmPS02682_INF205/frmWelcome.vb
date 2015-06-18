Public Class frmWelcome
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prbLoading.Increment(1)
        If prbLoading.Value = prbLoading.Maximum Then
            Me.Close()

        End If
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class