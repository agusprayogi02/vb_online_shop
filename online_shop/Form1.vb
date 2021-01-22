Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoginTableAdapter1.Fill(Me.UserDataSet1.login)
    End Sub
End Class
