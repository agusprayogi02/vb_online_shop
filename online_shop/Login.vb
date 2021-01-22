Imports System.Data.SqlClient
Public Class Login
    Private reader As SqlDataReader
    Private adapter As SqlDataAdapter

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnCencel.Click
        Me.Close()
    End Sub

    Private Sub kosong()
        txtCapt.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub makeCapt()
        Dim capt() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray
        Dim r As New Random
        Dim i = 0
        lbCapt.Text = ""
        Dim txt = ""
        While i < 6
            Dim index = r.Next(0, capt.Length - 1)
            txt &= capt(index)
            i += 1
        End While
        lbCapt.Text = txt
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim ds As New DataSet
        If txtEmail.Text.Trim = "" Or txtPassword.Text = "" Or txtCapt.Text.Trim = "" Then
            MessageBox.Show(Nothing, "Harus Diisi Semua!", "gagal", MessageBoxButtons.OK)
            Return
        End If

        If Not txtCapt.Text = lbCapt.Text Then
            MessageBox.Show(Nothing, "Kode Captcha Salah!", "gagal", MessageBoxButtons.OK)
            txtCapt.Text = ""
            Return
        End If
        Call cekkoneksi()
            adapter = New SqlDataAdapter("SELECT * FROM [dbo].[login] WHERE username='" + txtEmail.Text + "' AND password='" + txtPassword.Text + "'", conn)
            adapter.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Me.Hide()
                MenuUtama.Show()
            Else
                MessageBox.Show(Nothing, "Akun Salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call makeCapt()
    End Sub
End Class