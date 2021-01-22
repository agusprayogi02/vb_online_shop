Imports System.Data.SqlClient

Module Connection
    Public conn As New SqlConnection("Server=LAPTOP-GD393BFB;Database=user;Integrated Security=true;")
    Sub cekkoneksi()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
