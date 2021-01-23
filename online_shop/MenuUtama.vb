Public Class MenuUtama
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserDataSet.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.UserDataSet.login)
    End Sub

    Sub gantiKondisi()
        txtEmail.ReadOnly = Not txtEmail.ReadOnly
        txtPass.ReadOnly = Not txtPass.ReadOnly
        btnUpdate.Enabled = Not btnUpdate.Enabled
    End Sub

    Sub kosong()
        txtEmail.Text = ""
        txtId.Text = ""
        txtPass.Text = ""
    End Sub

    Sub getData()
        Dim i As Integer = DataGridView1.CurrentRow.Index
        With DataGridView1.Rows(i)
            txtId.Text = .Cells(0).Value.ToString
            txtEmail.Text = .Cells(1).Value.ToString
            txtPass.Text = .Cells(2).Value.ToString
        End With
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnAkun_Click(sender As Object, e As EventArgs) Handles btnAkun.Click, Button1.Click, Button2.Click
        btnAkun.BackColor = Color.SteelBlue
        Button1.BackColor = Color.SteelBlue
        Button2.BackColor = Color.SteelBlue
        If sender Is btnAkun Then
            btnAkun.BackColor = Color.LightBlue
        ElseIf sender Is Button1 Then
            Button1.BackColor = Color.LightBlue
        ElseIf sender Is Button2 Then
            Button2.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        getData()
    End Sub

    Private Sub btnInginUp_Click(sender As Object, e As EventArgs) Handles btnInginUp.Click
        gantiKondisi()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtId.Text.Trim = "" And txtEmail.Text.Trim = "" And txtPass.Text.Trim = "" Then
            MsgBox("Harus diisi Semua")
            Return
        End If
        If Not txtId.Text.Trim = "" Then
            If Me.LoginTableAdapter.UpdateQuery(txtEmail.Text.Trim, txtPass.Text, txtId.Text.Trim) Then
                Me.LoginTableAdapter.Fill(Me.UserDataSet.login)
                gantiKondisi()
                kosong()
            End If
        End If
    End Sub

    Private Sub btnCencel_Click(sender As Object, e As EventArgs) Handles btnCencel.Click
        kosong()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtEmail.Text.Trim = "" And txtPass.Text.Trim = "" Then
            MsgBox("Harus diisi Semua")
            Return
        End If
        If Me.LoginTableAdapter.InsertQuery(txtEmail.Text.Trim, txtPass.Text.Trim) Then
            Me.LoginTableAdapter.Fill(Me.UserDataSet.login)
            kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtId.Text.Trim = "" Then
            MsgBox("Id Harus diisi!")
            Return
        End If
        If MsgBox("Apa Anda Yakin ingin Menghapus Akun " + txtEmail.Text, MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            If Me.LoginTableAdapter.DeleteQuery(txtId.Text.Trim) Then
                Me.LoginTableAdapter.Fill(Me.UserDataSet.login)
                kosong()
            End If
        End If
    End Sub
End Class