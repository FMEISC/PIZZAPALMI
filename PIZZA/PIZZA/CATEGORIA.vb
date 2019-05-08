Imports System.Data
Imports System.Data.SqlClient
Public Class CATEGORIA
    Private Sub CATEGORIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Config.IniciarConexion()
    End Sub
    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles txtaccesoCategoria.Validated
        If txtaccesoCategoria.Text.Trim() = "" Then
            Exit Sub
        End If
        Dim acc As String = ""
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "AccesoUsuario"
        Comm.CommandType = CommandType.StoredProcedure
        Comm.Parameters.Add("@Id", SqlDbType.NChar, 10).Value = txtaccesoCategoria.Text.ToString()
        Config.IdUsuario = txtaccesoCategoria.ToString()
        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                acc = DReader("Nombre_Cat")


            End While
        Else
            MessageBox.Show("Usuario no encontrado", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        DReader.Close()
        Select Case acc.Trim()
            Case "Administrador"
                CATALOGO.Show()
            Case "Cajero"
                InicioCajas.Show()
            Case ""
                Exit Sub
        End Select
        Me.Close()
    End Sub


    Private Sub btnAccesoMa_Click(sender As Object, e As EventArgs) Handles btnAccesoMa.Click
        LoginForm1.Show()
        Me.Hide()

    End Sub

    Private Sub btnAccesoMa_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAccesoMa.KeyDown
        If e.KeyData = Keys.Enter Then
            btnAccesoMa.Select()
        End If
    End Sub

    Private Sub btnSalirCat_Click(sender As Object, e As EventArgs) Handles btnSalirCat.Click
        Me.Close()
    End Sub

    Private Sub txtaccesoCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtaccesoCategoria.TextChanged

    End Sub
End Class