Imports System.Net.Mail
Imports System.Data.SqlClient

Public Class Register
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, btnBatal.Click
        Login.Show()
        Hide()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRole.Items.Add("Admin")
        txtRole.Items.Add("Kasir")
        txtRole.Items.Add("Customer")
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        If txtPass.Text.Trim = "" And txtRole.Text = "" Then
            MsgBox("Harus Diisi Semua!")
            Return
        End If

        Try
            Dim mail = New MailAddress(txtEmail.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

        If txtPass.Text.Length < 6 Then
            MsgBox("Password Min 6!")
            Return
        End If

        If Not txtCaptBox.Text = txtCapt.Text Then
            MsgBox("Captcha Salah!")
            txtCaptBox.Text = ""
            txtCapt.Text = Login.makeCapt
            Return
        End If

        Call cekkoneksi()
        Try
            Dim dt As New DataTable
            Dim cmd = New SqlCommand("INSERT INTO login (username, password, role) VALUES (@username,@password,@role);", conn)
            cmd.Parameters.AddWithValue("@username", txtEmail.Text.Trim)
            cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim)
            cmd.Parameters.AddWithValue("@role", txtRole.SelectedItem.ToString)
            If cmd.ExecuteNonQuery() > 0 Then
                If MsgBox("Berhasil Mendaftar Akun!", MessageBoxButtons.OK) = MsgBoxResult.Ok Then
                    Login.Show()
                    Hide()
                    Return
                End If
                Login.Show()
                Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Private Sub Register_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtCapt.Text = Login.makeCapt
    End Sub
End Class