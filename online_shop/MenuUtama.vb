Public Class MenuUtama
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuUtama_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub
End Class