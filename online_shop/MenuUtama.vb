﻿Imports System.Text.RegularExpressions

Public Class MenuUtama
    Public id As Integer

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserDataSet.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.UserDataSet.login)
        'TODO: This line of code loads data into the 'UserDataSet.pembelian' table. You can move, or remove it, as needed.
        Me.PembelianTableAdapter.Fill(Me.UserDataSet.pembelian)
        'TODO: This line of code loads data into the 'UserDataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.UserDataSet.barang)
        ComboRole.Items.Add("Admin")
        ComboRole.Items.Add("Customer")
        With btnUser
            .BackColor = Color.Blue
            .ForeColor = Color.White
            .FlatAppearance.BorderSize = 1
            LbTitle.Text = .Text.ToString
        End With
    End Sub

    Sub gantiKondisi()
        txtEmail.ReadOnly = Not txtEmail.ReadOnly
        txtPass.ReadOnly = Not txtPass.ReadOnly
        btnUpdate.Enabled = Not btnUpdate.Enabled
        ComboRole.Enabled = Not ComboRole.Enabled
    End Sub

    Sub kosong()
        txtEmail.Text = ""
        txtId.Text = ""
        txtPass.Text = ""
        ComboRole.Text = ""
    End Sub

    Sub kosongkanBarang()
        IdTextBox.Text = id.ToString
        KdTextBox.Text = ""
        NamaTextBox.Text = ""
        HargaTextBox.Text = ""
        StokTextBox.Text = ""
    End Sub

    Sub getData()
        Dim i As Integer = DataGridView1.CurrentRow.Index
        With DataGridView1.Rows(i)
            txtId.Text = .Cells(0).Value.ToString
            txtEmail.Text = .Cells(1).Value.ToString
            txtPass.Text = .Cells(2).Value.ToString
            ComboRole.Text = .Cells(3).Value.ToString
        End With
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    'Private Sub btnAkun_Click(sender As Object, e As EventArgs)
    '    btnAkun.BackColor = Color.SteelBlue
    '    Button1.BackColor = Color.SteelBlue
    '    Button2.BackColor = Color.SteelBlue
    '    If sender Is btnAkun Then
    '        btnAkun.BackColor = Color.LightBlue
    '    ElseIf sender Is Button1 Then
    '        Button1.BackColor = Color.LightBlue
    '    ElseIf sender Is Button2 Then
    '        Button2.BackColor = Color.LightBlue
    '    End If
    'End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
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
            If Me.LoginTableAdapter.UpdateQuery(txtEmail.Text.Trim, txtPass.Text, ComboRole.Text, txtId.Text.Trim) Then
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
        If Me.LoginTableAdapter.InsertQuery(txtEmail.Text.Trim, txtPass.Text.Trim, ComboRole.SelectedItem.ToString) Then
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBarang.Click, btnUser.Click, btnPembelian.Click
        Dim listBtn() As Button = {btnBarang, btnUser, btnPembelian}
        Dim listPanel() As Panel = {pBarang, pUser, pPembelian}
        Dim i = 0

        For Each btn As Button In listBtn
            listPanel(i).Visible = False
            With btn
                .BackColor = Color.SteelBlue
                .ForeColor = Color.Black
                .FlatAppearance.BorderSize = 0
            End With
            If sender Is btn Then
                listPanel(i).Visible = True
                With btn
                    .BackColor = Color.Blue
                    .ForeColor = Color.White
                    .FlatAppearance.BorderSize = 1
                    LbTitle.Text = .Text.ToString
                End With
            End If
            i += 1
        Next

        'If sender Is Button3 Then
        '    pBottom.Visible = True

        'Else
        '    pTop.Visible = True
        '    With Button4
        '        .BackColor = Color.Blue
        '        .ForeColor = Color.White
        '        .FlatAppearance.BorderSize = 1
        '        LbTitle.Text = .Text.ToString
        '    End With
        'End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick
        Call getData()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub btnKosongkan_Click(sender As Object, e As EventArgs) Handles btnKosongkan.Click
        Call kosongkanBarang()
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        If NamaTextBox.Text.Trim = "" And HargaTextBox.Text.Trim = "" And StokTextBox.Text.Trim = "" Then
            MsgBox("Id Harus diisi!")
            Return
        End If

        If Me.BarangTableAdapter.InsertQuery(id, NamaTextBox.Text, HargaTextBox.Text, StokTextBox.Text) Then
            Me.BarangTableAdapter.Fill(Me.UserDataSet.barang)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NamaTextBox.Text.Trim = "" And HargaTextBox.Text.Trim = "" And StokTextBox.Text.Trim = "" Then
            MsgBox("Id Harus diisi!")
            Return
        End If

        If Me.BarangTableAdapter.UpdateQuery(NamaTextBox.Text, HargaTextBox.Text, StokTextBox.Text, id, KdTextBox.Text) Then
            Me.BarangTableAdapter.Fill(Me.UserDataSet.barang)
        End If
    End Sub

    Private Sub StokTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HargaTextBox_TextChanged(sender As Object, e As EventArgs)
        Dim reg As New Regex("[^\d]")
        HargaTextBox.Text = reg.Replace(HargaTextBox.Text, "")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If KdTextBox.Text.Trim = "" Then
            MsgBox("Kd Barang Hapus di Isi!")
            Return
        End If

        If MsgBox("yakin Ingin Hapus?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Me.BarangTableAdapter.DeleteQuery(KdTextBox.Text) Then
                Me.BarangTableAdapter.Fill(Me.UserDataSet.barang)
            End If
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Beli_idTextBox.Text = ""
        UsernameTextBox.Text = ""
        NamaComboBox.Text = ""
        Beli_jumlahTextBox.Text = ""
        Beli_tanggalDateTimePicker.Value = Now
    End Sub
End Class