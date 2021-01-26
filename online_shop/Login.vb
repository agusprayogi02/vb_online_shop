Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text.RegularExpressions
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

    Public Function makeCapt() As String
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
        Return txt
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim emailvalidator = New MailAddress(txtEmail.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

        Dim ds As New DataSet
        If txtEmail.Text.Trim = "" Or txtPassword.Text = "" Or txtCapt.Text.Trim = "" Then
            MessageBox.Show(Nothing, "Harus Diisi Semua!", "gagal", MessageBoxButtons.OK)
            Return
        End If

        If Not txtCapt.Text = lbCapt.Text Then
            MessageBox.Show(Nothing, "Kode Captcha Salah!", "gagal", MessageBoxButtons.OK)
            txtCapt.Text = ""
            lbCapt.Text = makeCapt()
            Return
        End If
        Call cekkoneksi()
        adapter = New SqlDataAdapter("SELECT * FROM [dbo].[login] WHERE username='" + txtEmail.Text + "' AND password='" + txtPassword.Text + "'", conn)
        adapter.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim role = ds.Tables(0).Rows(0).Field(Of String)("role")
            If role = "Admin" Then
                MenuUtama.Show()
                MenuUtama.id = ds.Tables(0).Rows(0).Field(Of Integer)("id")
                Hide()
            ElseIf role = "Kasir" Then
            Else

            End If
        Else
            MessageBox.Show(Nothing, "Akun Salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Activated
        lbCapt.Text = makeCapt()
    End Sub



    'Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
    '    If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ' number Only
        'Dim dig As Regex = New Regex("[^\d]")
        'txtEmail.Text = dig.Replace(txtEmail.Text, "")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Register.Show()
        Hide()
    End Sub
End Class